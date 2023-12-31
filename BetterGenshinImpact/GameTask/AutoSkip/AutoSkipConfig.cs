﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGenshinImpact.GameTask.AutoSkip
{
    /// <summary>
    /// 自动跳过剧情配置
    /// </summary>
    [Serializable]
    public partial class AutoSkipConfig : ObservableObject
    {
        /// <summary>
        /// 触发器是否启用
        /// 启用后：
        /// 1. 快速跳过对话
        /// 2. 自动点击一个识别到的选项
        /// 3. 黑屏过长自动点击跳过
        /// </summary>
        [ObservableProperty] private bool _enabled = true;

        /// <summary>
        /// 快速跳过对话
        /// </summary>
        [ObservableProperty] private bool _quicklySkipConversationsEnabled = true;

        public int ChatOptionTextWidth { get; set; }= 280;

        public int ExpeditionOptionTextWidth { get; set; } = 130;


        /// <summary>
        /// 自动领取每日委托奖励
        /// </summary>
        [ObservableProperty] private bool _autoGetDailyRewardsEnabled = true;

        /// <summary>
        /// 自动重新派遣
        /// </summary>
        [ObservableProperty] private bool _autoReExploreEnabled = true;

        /// <summary>
        /// 自动重新派遣使用角色配置，逗号分割
        /// </summary>
        [ObservableProperty] private string _autoReExploreCharacter = "";
    }
}
