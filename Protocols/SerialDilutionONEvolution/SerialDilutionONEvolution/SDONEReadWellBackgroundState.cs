﻿/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 23/04/2014
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using OctoTip.Lib.ExperimentsCore.Attributes;

namespace SerialDilutionONEvolution
{
	/// <summary>
	/// Description of SDONEReadWellbackgroundState.
	/// </summary>
	[State("Read well background ","Read well OD for future analysis")]
	public class SDONEReadWellBackgroundState:SDONEReadState
	{
		public SDONEReadWellBackgroundState(int LicPlateInd,int Well):base( LicPlateInd,Well)
			
		{
		}
		
		
		public double BackgroundWellOD
		{
			get{return _WellOD;}
		}
		
		
		#region static
		public static new List<Type> NextStates()
		{
			return new List<Type>{typeof(SDONEWait4ReadState)};
		}
		#endregion
	}
}