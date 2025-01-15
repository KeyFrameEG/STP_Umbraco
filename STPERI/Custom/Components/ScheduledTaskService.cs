using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using Microsoft.Extensions.Hosting;

public class ScheduledTaskService : IHostedService, IDisposable
{
    private readonly IContentService _contentService;
    private readonly ILogger<ScheduledTaskService> _logger;
    private Timer _timer;

    public ScheduledTaskService(IContentService contentService, ILogger<ScheduledTaskService> logger)
    {
        _contentService = contentService;
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        // Schedule the task to run every hour
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromHours(1));
        return Task.CompletedTask;
    }

    private void DoWork(object state)
    {
        _logger.LogInformation("Scheduled Task Started");

        try
        {
            MoveExpiredUpcomingEvents();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred in Scheduled Task");
        }
    }

    private void MoveExpiredUpcomingEvents()
    {
        // Replace these IDs with your actual node IDs
        Guid upcomingEventsPageId = new Guid("5023");
        Guid eventsPageId = new Guid("3527");

        var upcomingEventsPage = _contentService.GetById(upcomingEventsPageId);
        var eventsPage = _contentService.GetById(eventsPageId);

        if (upcomingEventsPage == null || eventsPage == null)
        {
            _logger.LogWarning("One or both pages could not be found.");
            return;
        }

        // Fetch the properties
        var upcomingNews = upcomingEventsPage.GetValue<List<LatestNewsItem>>("latestNewsProperty");
        var eventsNews = eventsPage.GetValue<List<LatestNewsItem>>("latestNewsProperty");

        if (upcomingNews == null || eventsNews == null)
        {
            _logger.LogWarning("One or both properties are null.");
            return;
        }

        var currentDate = DateTime.UtcNow;

        // Move items based on date
        var itemsToMove = upcomingNews.Where(item => item.DateFormat <= currentDate).ToList();

        if (itemsToMove.Any())
        {
            foreach (var item in itemsToMove)
            {
                upcomingNews.Remove(item);
                eventsNews.Add(item);
            }

            // Save updated properties back to their respective nodes
            upcomingEventsPage.SetValue("latestNewsProperty", upcomingNews);
            eventsPage.SetValue("latestNewsProperty", eventsNews);

            // Save and publish changes
            _contentService.SaveAndPublish(upcomingEventsPage);
            _contentService.SaveAndPublish(eventsPage);

            _logger.LogInformation($"Moved {itemsToMove.Count} items from Upcoming Events to Events.");
        }
        else
        {
            _logger.LogInformation("No items to move.");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}

public class LatestNewsItem
{
    public DateTime DateFormat { get; set; }
    public string Title { get; set; }
    public string RedirectUrl { get; set; }
    public string Category { get; set; }
    public string Date { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Location { get; set; }
    // Add other properties as needed
}
