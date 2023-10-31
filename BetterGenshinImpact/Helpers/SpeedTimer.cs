﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BetterGenshinImpact.Helpers;

public class SpeedTimer
{
    private readonly Stopwatch _stopwatch;

    private readonly Dictionary<string, TimeSpan> _timeRecordDic = new();


    public SpeedTimer()
    {
        _stopwatch = new Stopwatch();
        _stopwatch.Start();
    }

    public void Record(string name)
    {
        _timeRecordDic[name] = _stopwatch.Elapsed;
        _stopwatch.Restart();
    }

    public void DebugPrint()
    {
        var msg = string.Empty;
        foreach (var pair in _timeRecordDic)
        {
            //if (pair.Value.TotalMilliseconds > 0)
            //{
                msg += $"{pair.Key}:{pair.Value.TotalMilliseconds}ms,";
            //}

        }

        if (msg.Length > 0)
        {
            Debug.WriteLine(msg[..^1]);
        }
        _stopwatch.Stop();
    }
}