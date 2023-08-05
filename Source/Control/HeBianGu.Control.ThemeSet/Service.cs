﻿// Copyright © 2022 By HeBianGu(QQ:908293466) https://github.com/HeBianGu/WPF-ControlBase

using HeBianGu.Base.WpfBase;

namespace HeBianGu.Control.ThemeSet
{
    public class ThemeSaveService : IThemeSaveService
    {
        public string Name => "主题配置";
        public bool Save(out string message)
        {
            ThemeConfig.Instance = ThemeViewModel.Current.SaveTo();
            return ThemeConfig.Instance.Save(out message);
        }
    }
}
