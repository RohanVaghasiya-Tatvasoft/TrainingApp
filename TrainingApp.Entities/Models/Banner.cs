﻿using System;
using System.Collections.Generic;

namespace TrainingApp.Entities.Models;

public partial class Banner
{
    public int BannerId { get; set; }

    public string Image { get; set; } = null!;

    public string? Text { get; set; }

    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
