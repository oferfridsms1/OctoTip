﻿/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 01/11/2012
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using OctoTip.Lib.ExperimentsCore.Attributes;
using OctoTip.Lib.ExperimentsCore.Base;

namespace SerialDilutionEvolution
{
	/// <summary>
	/// Description of SDEProtocolParameters.
	/// </summary>
	public class SDEProtocolParameters:ProtocolParameters
	{
		public SDEProtocolParameters()
		{
		}
		[ProtocolParameterAtribute("Cycle","0",true)]
		public int Cycle;
		[ProtocolParameterAtribute("Liconic curent plate Index","0",true)]
		public int LicPlatePosition;
		[ProtocolParameterAtribute("Liconic curent plate Indexes","1,2,3",true)]
		public int[] LicPlatePositions;
		[ProtocolParameterAtribute("Curent well","1",true)]
		public int CurentWell;
		[ProtocolParameterAtribute("Wells to freeze","1,4,3",true)]
		public int[] FreezeWells;
		[ProtocolParameterAtribute("Time Till the first OD (Hours)","1.5",true)]
		public double Time4TheFirstODTest;
		[ProtocolParameterAtribute("Log file path",@"D:\OctoTip\Protocols\SerialDilutionEvolution\Output\")]
		public string OutputFilePath;
		[ProtocolParameterAtribute("Shared Resources file path",@"D:\OctoTip\Protocols\SerialDilutionEvolution\SharedResources\")]
		public string SharedResourcesFilePath;
		
	}
}