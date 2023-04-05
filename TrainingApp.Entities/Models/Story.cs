﻿using System;
using System.Collections.Generic;

namespace TrainingApp.Entities.Models;

public partial class Story
{
    public int StoryId { get; set; }

    public int UserId { get; set; }

    public int MissionId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? PublishedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Mission Mission { get; set; } = null!;

    public virtual ICollection<StoryMedium> StoryMedia { get; } = new List<StoryMedium>();

    public virtual ICollection<StotyInvite> StotyInvites { get; } = new List<StotyInvite>();

    public virtual User User { get; set; } = null!;
}
