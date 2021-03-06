﻿using System.Reflection;
using CarEyeClient.Model;
using CarEyeClient.Properties;

namespace CarEyeClient
{
	/// <summary>
	/// 全局访问的配置信息
	/// </summary>
	internal static class GlobalCfg
	{
		/// <summary>
		/// Player库密钥
		/// </summary>
		public const string DVRKey = "79393674363469576B5A73416C4A6861705764727065394459584A466557564462476C6C626E51755A58686C766C634D5671442F7065424859585A7062695A4359574A76633246414D6A41784E6B566863336C4559584A33615735555A5746745A57467A65513D3D";

		/// <summary>
		/// 获取本项目的标题
		/// </summary>
		public static string Title
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyTitleAttribute)attributes[0]).Title;
			}
		}

		/// <summary>
		/// 本应用程序的公司名称
		/// </summary>
		public static string Company
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}

		/// <summary>
		/// 获取本应用程序的版本号
		/// </summary>
		public static string Version
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		/// <summary>
		/// 本项目用到的长时间输出格式
		/// </summary>
		public const string TimeFormat = "yyyy-MM-dd HH:mm:ss";

		/// <summary>
		/// 平台密钥AK
		/// </summary>
		public const string ServerKey = "zhvvc2vuz2f0zte1mtcznza5mzqymje=";
		/// <summary>
		/// 目前测试使用的终端编号
		/// </summary>
		public static string TerminalId { get; set; } = "18668171282";
		
		/// <summary>
		/// 生成对应的视频播放地址
		/// </summary>
		/// <param name="aTerminalId">终端编号</param>
		/// <param name="aChn">通道号</param>
		/// <returns></returns>
		public static string GenRTSPUrl(string aTerminalId, AVChannel aChn)
		{
			return string.Format("rtsp://{0}:{1}/{2}?channel={3}.sdp",
								Settings.Default.DVRSvrIp,
								Settings.Default.DVRSvrPort,
								aTerminalId, (byte)aChn);
		}
	}
}
