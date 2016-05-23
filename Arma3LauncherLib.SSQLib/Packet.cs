/*
 * This file is part of SSQLib.
 *
 *   SSQLib is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   SSQLib is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU Lesser General Public License for more details.
 *
 *   You should have received a copy of the GNU Lesser General Public License
 *   along with SSQLib.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Text;

namespace DerAtrox.Arma3LauncherLib.SSQLib {
    internal class Packet {
        internal string Data = "";
        internal int RequestId = 0;

        //Output the packet data as a byte array
        internal byte[] OutputAsBytes() {
            byte[] dataByte;

            if (Data.Length > 0) {
                //Create a new packet based on the length of the request
                dataByte = new byte[Data.Length + 5];

                //Fill the first 4 bytes with 0xff
                dataByte[0] = 0xff;
                dataByte[1] = 0xff;
                dataByte[2] = 0xff;
                dataByte[3] = 0xff;

                //Copy the data to the new request
                Array.Copy(Encoding.UTF8.GetBytes(Data), 0, dataByte, 4, Data.Length);
            }
            //Empty request to get challenge
            else {
                dataByte = new byte[5];

                //Fill the first 4 bytes with 0xff
                dataByte[0] = 0xff;
                dataByte[1] = 0xff;
                dataByte[2] = 0xff;
                dataByte[3] = 0xff;
                dataByte[4] = 0x57;
            }


            return dataByte;
        }
    }
}