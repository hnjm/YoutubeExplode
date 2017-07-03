﻿using System;
using System.Globalization;

namespace YoutubeExplode.Models.ClosedCaptions
{
    /// <summary>
    /// Closed caption track info
    /// </summary>
    public class ClosedCaptionTrackInfo
    {
        /// <summary>
        /// Manifest URL
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Text culture
        /// </summary>
        public Language Language { get; }

        /// <summary>
        /// Whether this caption track was generated automatically
        /// </summary>
        public bool IsAutoGenerated { get; }

        /// <inheritdoc />
        public ClosedCaptionTrackInfo(string url, Language language, bool isAutoGenerated)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url));
            Language = language ?? throw new ArgumentNullException(nameof(language));
            IsAutoGenerated = isAutoGenerated;
        }
    }
}