﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VGClipTrimmer.Helpers;

namespace VGClipTrimmer.MVVM.Models.Interfaces
{
    public interface IVideoProcessingService
    {
        VideoFileInfo GetVideoFileInfo(string pathToVideo);
        Task<object> ProcessVideoFile(string pathToVideo, IProgress<int> progress, CancellationToken token);
    }
}
