﻿using NLog;
using System;
namespace NLogDemo
{
	public class Adding
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		public static void Sum(int first, int Second)
		{
			if (first <= 0 || Second <= 0)
			{
				logger.Warn("Please privide +ve value");
				logger.Error("Number should not be below zero");
				logger.Debug("Debug failed");
			}
			else
			{
				int sum = first + Second;
				logger.Debug("Debugging with sum operation successfull");
				logger.Info("Sum Result: " + sum);
			}
		}
	}
}

