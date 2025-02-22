﻿namespace Podcast.Infrastructure.Data.Models;

public class Episode
{
    public Episode(
        string description, 
        TimeSpan? duration, 
        string @explicit, 
        DateTime published, 
        string title, 
        string url,
        string image,
        int order)
    {
        Description = description;
        Duration = duration;
        Explicit = @explicit;
        Published = published;
        Title = title;
        Url = url;
        Order = order;
        Image = image;
    }

    public Guid Id { get; private set; }
    public int Order { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Explicit { get; private set; }
    public DateTime Published { get; private set; }
    public TimeSpan? Duration { get; private set; }
    public string Url { get; private set; }
    public string Image { get; private set; }
    public Show Show { get; private set; } = null!;
}