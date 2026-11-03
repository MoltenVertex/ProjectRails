//Simplified BSD License (BSD-2-Clause)
//
//Copyright (c) 2020, Christopher Lees, The OpenBVE Project
//
//Redistribution and use in source and binary forms, with or without
//modification, are permitted provided that the following conditions are met:
//
//1. Redistributions of source code must retain the above copyright notice, this
//   list of conditions and the following disclaimer.
//2. Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution.
//
//THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
//DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
//ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
//(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
//LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
//ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
//(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.IO;

namespace LBAHeader
{
	static class FixLBAHeader
	{
		static byte[] data;
		static void Main(string[] args)
		{
			string f = string.Empty;
			if (args.Length >= 1)
			{
				f = args[0];
			}
			if (!File.Exists(f))
			{
				//If we can't find our initial argument, try and locate the openBVE executable in our directory
				string ff = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
				if (ff == null)
				{
					Console.WriteLine("Unable to find the executing assembly path....");
					return;
				}
				f = Path.Combine(ff, "OpenBve.exe");
			}
			if (!File.Exists(f))
			{
				//Not found, log this rather than crashing
				Console.WriteLine("No suitable executables found....");
				return;
			}
			AddLbaFlag(f);
			// ReSharper disable once AssignNullToNotNullAttribute
			f = Path.Combine(Path.GetDirectoryName(f), "RouteViewer.exe");
			if (!File.Exists(f))
			{
				//Not found, log this rather than crashing
				Console.WriteLine("RouteViewer executable not found....");
				return;
			}
			AddLbaFlag(f);
		}

		/// <summary>Marks an executable as LBA aware</summary>
		static void AddLbaFlag(string f)
		{
			Console.WriteLine("Adding LBA Flag to executable {0}", f);
			try
			{
				data = File.ReadAllBytes(f);
				var offset = BitConverter.ToInt32(data, 0x3c);
				//Set LBA Flag for the file supplied via Arguments[0]
				data[offset + 4 + 18] |= 0x20;
				File.WriteAllBytes(f, data);
			}
			catch
			{
				Console.WriteLine("A problem occured whilst attempting to set the LBA flag for executable " + f);
			}
		}

	}
}
