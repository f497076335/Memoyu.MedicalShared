﻿/**************************************************************************  
*   =================================
*   CLR版本  ：4.0.30319.42000
*   文件名称 ：IStatusBarPlatformSpecific
*   =================================
*   创 建 者 ：Memoyu
*   创建日期 ：2020/4/25 15:45:29
*   功能描述 ：
*   =================================
*   修 改 者 ：
*   修改日期 ：
*   修改内容 ：
*   ================================= 
***************************************************************************/

using System.Drawing;

namespace MedicalShredApp.Services
{
    public interface IStatusBarPlatformSpecific
    {
        void SetLightTheme();
        void SetDarkTheme();
    }
}
