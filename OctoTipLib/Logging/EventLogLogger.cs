﻿/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 02/04/2014
 * Time: 10:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;

namespace OctoTip.Lib.Logging
{
	/// <summary>
	/// Description of EventLogLogger.
	/// </summary>
	public class EventLogLogger:Logger
	{
		private string SourceName;
		
		
		public EventLogLogger()
		{
			SourceName = System.AppDomain.CurrentDomain.FriendlyName;
			try
			{
				if(!EventLog.SourceExists(SourceName))
				{
					
					EventLog.CreateEventSource(SourceName, "Application");
					
					
				}
				
			}
			catch(System.Security.SecurityException e)
			{
				throw new Exception("Event Log Logger is not registered! \n run as administrator for the first time.",e);
			}
			LoggerName = "Event Log";
			LoggigLevel = (int)LoggingEntery.EnteryTypes.Warning;
			
		}
		
		override public void Log(LoggingEntery LE)
		{
			// Create an EventLog instance and assign its source.
			EventLog myLog = new EventLog();
			myLog.Source = SourceName;

			// Write an informational entry to the event log.
			string Messeg = string.Format("{0}({1}): {2}\n--------------\n{3}",LE.Sender,LE.SubSender,LE.Title,LE.Message);
			myLog.WriteEntry(Messeg,GetEntryType(LE.EnteryType));
		}
		
		private EventLogEntryType GetEntryType(LoggingEntery.EnteryTypes LEET)
		{
			EventLogEntryType ET;
			switch (LEET)
			{
				case LoggingEntery.EnteryTypes.Warning:
					ET = EventLogEntryType.Warning;
					break;
				case LoggingEntery.EnteryTypes.Informational:
					ET = EventLogEntryType.Information;
					break;
				case LoggingEntery.EnteryTypes.Debug:
					ET = EventLogEntryType.Information;
					break;
				case LoggingEntery.EnteryTypes.Error:
					ET = EventLogEntryType.Error;
					break;
				case LoggingEntery.EnteryTypes.Critical:
					ET = EventLogEntryType.Error;
					break;
				default:
					ET = EventLogEntryType.Information;
					break;
			}
			return ET;
		}
	}
}