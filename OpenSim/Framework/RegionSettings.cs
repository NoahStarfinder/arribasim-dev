/*
 * Copyright (c) Contributors, http://opensimulator.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSimulator Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.IO;
using OpenMetaverse;

namespace OpenSim.Framework
{
    public class RegionSettings
    {
        public delegate void SaveDelegate(RegionSettings rs);

        public event SaveDelegate OnSave;
        
        /// <value>
        /// These appear to be terrain textures that are shipped with the client.
        /// </value>
        public static readonly UUID DEFAULT_TERRAIN_TEXTURE_1 = new UUID("b8d3965a-ad78-bf43-699b-bff8eca6c975");
        public static readonly UUID DEFAULT_TERRAIN_TEXTURE_2 = new UUID("abb783e6-3e93-26c0-248a-247666855da3");
        public static readonly UUID DEFAULT_TERRAIN_TEXTURE_3 = new UUID("179cdabd-398a-9b6b-1391-4dc333ba321f");
        public static readonly UUID DEFAULT_TERRAIN_TEXTURE_4 = new UUID("beb169c7-11ea-fff2-efe5-0f24dc881df2");

        public void Save()
        {
            if (OnSave != null)
                OnSave(this);
        }

        private UUID m_RegionUUID = UUID.Zero;

        public UUID RegionUUID
        {
            get { return m_RegionUUID; }
            set { m_RegionUUID = value; }
        }

        private bool m_BlockTerraform = false;

        public bool BlockTerraform
        {
            get { return m_BlockTerraform; }
            set { m_BlockTerraform = value; }
        }

        private bool m_BlockFly = false;

        public bool BlockFly
        {
            get { return m_BlockFly; }
            set { m_BlockFly = value; }
        }

        private bool m_AllowDamage = false;

        public bool AllowDamage
        {
            get { return m_AllowDamage; }
            set { m_AllowDamage = value; }
        }

        private bool m_RestrictPushing = false;

        public bool RestrictPushing
        {
            get { return m_RestrictPushing; }
            set { m_RestrictPushing = value; }
        }

        private bool m_AllowLandResell = true;

        public bool AllowLandResell
        {
            get { return m_AllowLandResell; }
            set { m_AllowLandResell = value; }
        }

        private bool m_AllowLandJoinDivide = true;

        public bool AllowLandJoinDivide
        {
            get { return m_AllowLandJoinDivide; }
            set { m_AllowLandJoinDivide = value; }
        }

        private bool m_BlockShowInSearch = false;

        public bool BlockShowInSearch
        {
            get { return m_BlockShowInSearch; }
            set { m_BlockShowInSearch = value; }
        }

        private int m_AgentLimit = 40;

        public int AgentLimit
        {
            get { return m_AgentLimit; }
            set { m_AgentLimit = value; }
        }

        private double m_ObjectBonus = 1.0;

        public double ObjectBonus
        {
            get { return m_ObjectBonus; }
            set { m_ObjectBonus = value; }
        }

        private int m_Maturity = 1;

        public int Maturity
        {
            get { return m_Maturity; }
            set { m_Maturity = value; }
        }

        private bool m_DisableScripts = false;

        public bool DisableScripts
        {
            get { return m_DisableScripts; }
            set { m_DisableScripts = value; }
        }

        private bool m_DisableCollisions = false;

        public bool DisableCollisions
        {
            get { return m_DisableCollisions; }
            set { m_DisableCollisions = value; }
        }

        private bool m_DisablePhysics = false;

        public bool DisablePhysics
        {
            get { return m_DisablePhysics; }
            set { m_DisablePhysics = value; }
        }

        private UUID m_TerrainTexture1 = UUID.Zero;

        public UUID TerrainTexture1
        {
            get { return m_TerrainTexture1; }
            set
            {
                if (value == UUID.Zero)
                    m_TerrainTexture1 = DEFAULT_TERRAIN_TEXTURE_1;
                else
                    m_TerrainTexture1 = value;
            }
        }

        private UUID m_TerrainTexture2 = UUID.Zero;

        public UUID TerrainTexture2
        {
            get { return m_TerrainTexture2; }
            set
            {
                if (value == UUID.Zero)
                    m_TerrainTexture2 = DEFAULT_TERRAIN_TEXTURE_2;
                else
                    m_TerrainTexture2 = value;
            }
        }

        private UUID m_TerrainTexture3 = UUID.Zero;

        public UUID TerrainTexture3
        {
            get { return m_TerrainTexture3; }
            set
            {
                if (value == UUID.Zero)
                    m_TerrainTexture3 = DEFAULT_TERRAIN_TEXTURE_3;
                else
                    m_TerrainTexture3 = value;
            }
        }

        private UUID m_TerrainTexture4 = UUID.Zero;

        public UUID TerrainTexture4
        {
            get { return m_TerrainTexture4; }
            set
            {
                if (value == UUID.Zero)
                    m_TerrainTexture4 = DEFAULT_TERRAIN_TEXTURE_4;
                else
                    m_TerrainTexture4 = value;
            }
        }

        private double m_Elevation1NW = 10;

        public double Elevation1NW
        {
            get { return m_Elevation1NW; }
            set { m_Elevation1NW = value; }
        }

        private double m_Elevation2NW = 60;

        public double Elevation2NW
        {
            get { return m_Elevation2NW; }
            set { m_Elevation2NW = value; }
        }

        private double m_Elevation1NE = 10;

        public double Elevation1NE
        {
            get { return m_Elevation1NE; }
            set { m_Elevation1NE = value; }
        }

        private double m_Elevation2NE = 60;

        public double Elevation2NE
        {
            get { return m_Elevation2NE; }
            set { m_Elevation2NE = value; }
        }

        private double m_Elevation1SE = 10;

        public double Elevation1SE
        {
            get { return m_Elevation1SE; }
            set { m_Elevation1SE = value; }
        }

        private double m_Elevation2SE = 60;

        public double Elevation2SE
        {
            get { return m_Elevation2SE; }
            set { m_Elevation2SE = value; }
        }

        private double m_Elevation1SW = 10;

        public double Elevation1SW
        {
            get { return m_Elevation1SW; }
            set { m_Elevation1SW = value; }
        }

        private double m_Elevation2SW = 60;

        public double Elevation2SW
        {
            get { return m_Elevation2SW; }
            set { m_Elevation2SW = value; }
        }

        private double m_WaterHeight = 20;

        public double WaterHeight
        {
            get { return m_WaterHeight; }
            set { m_WaterHeight = value; }
        }

        private double m_TerrainRaiseLimit = 100;

        public double TerrainRaiseLimit
        {
            get { return m_TerrainRaiseLimit; }
            set { m_TerrainRaiseLimit = value; }
        }

        private double m_TerrainLowerLimit = -100;

        public double TerrainLowerLimit
        {
            get { return m_TerrainLowerLimit; }
            set { m_TerrainLowerLimit = value; }
        }

        private bool m_UseEstateSun = true;

        public bool UseEstateSun
        {
            get { return m_UseEstateSun; }
            set { m_UseEstateSun = value; }
        }

        private bool m_Sandbox = false;

        public bool Sandbox
        {
            get { return m_Sandbox; }
            set { m_Sandbox = value; }
        }

        private Vector3 m_SunVector;

        public Vector3 SunVector
        {
            get { return m_SunVector; }
            set { m_SunVector = value; }
        }

        private UUID m_TerrainImageID;

        public UUID TerrainImageID
        {
            get { return m_TerrainImageID; }
            set { m_TerrainImageID = value; }
        }

        private bool m_FixedSun = false;

        public bool FixedSun
        {
            get { return m_FixedSun; }
            set { m_FixedSun = value; }
        }

        private double m_SunPosition = 0.0;

        public double SunPosition
        {
            get { return m_SunPosition; }
            set { m_SunPosition = value; }
        }

        private UUID m_Covenant = UUID.Zero;

        public UUID Covenant
        {
            get { return m_Covenant; }
            set { m_Covenant = value; }
        }

        private int m_LoadedCreationDateTime;
        public int LoadedCreationDateTime
        {
            get { return m_LoadedCreationDateTime; }
            set { m_LoadedCreationDateTime = value; }
        }
        
        public String LoadedCreationDate
        {
            get 
            { 
                TimeSpan ts = new TimeSpan(0, 0, LoadedCreationDateTime);
                DateTime stamp = new DateTime(1970, 1, 1) + ts;
                return stamp.ToLongDateString(); 
            }
        }

        public String LoadedCreationTime
        {
            get 
            { 
                TimeSpan ts = new TimeSpan(0, 0, LoadedCreationDateTime);
                DateTime stamp = new DateTime(1970, 1, 1) + ts;
                return stamp.ToLongTimeString(); 
            }
        }

        private String m_LoadedCreationID;
        public String LoadedCreationID
        {
            get { return m_LoadedCreationID; }
            set { m_LoadedCreationID = value; }
        }

        // Telehub support
        private bool m_TelehubEnabled = false;
        public bool HasTelehub
        {
            get { return m_TelehubEnabled; }
            set { m_TelehubEnabled = value; }
        }

        // Connected Telehub object
        private UUID m_TelehubObject;
        public UUID TelehubObject
        {
            get
            {
                if (HasTelehub)
                {
                    return m_TelehubObject;
                }
                else
                {
                    return UUID.Zero;
                }
            }
            set
            {
                m_TelehubObject = value;
            }
        }

        // Connected Telehub name
        private string m_TelehubName;
        public string TelehubName
        {
            get
            {
                if (HasTelehub)
                {
                    return m_TelehubName;
                }
                else
                {
                    return String.Empty;
                }
            }
            set
            {
                m_TelehubName = value;
            }
        }

        // Connected Telehub position
        private float m_TelehubPosX;
        private float m_TelehubPosY;
        private float m_TelehubPosZ;
        public Vector3 TelehubPos
        {
            get
            {
                if (HasTelehub)
                {
                    Vector3 Pos = new Vector3(m_TelehubPosX, m_TelehubPosY, m_TelehubPosZ);
                    return Pos;
                }
                else
                {
                    return Vector3.Zero;
                }
            }
            set
            {

                m_TelehubPosX = value.X;
                m_TelehubPosY = value.Y;
                m_TelehubPosZ = value.Z;
            }
        }

        // Connected Telehub rotation
        private float m_TelehubRotX;
        private float m_TelehubRotY;
        private float m_TelehubRotZ;
        private float m_TelehubRotW;
        public Quaternion TelehubRot
        {
            get
            {
                if (HasTelehub)
                {
                    Quaternion quat = new Quaternion();

                    quat.X = m_TelehubRotX;
                    quat.Y = m_TelehubRotY;
                    quat.Z = m_TelehubRotZ;
                    quat.W = m_TelehubRotW;

                    return quat;
                }
                else
                {
                    // What else to do??
                    Quaternion quat = new Quaternion();

                    quat.X = m_TelehubRotX;
                    quat.X = m_TelehubRotY;
                    quat.X = m_TelehubRotZ;
                    quat.X = m_TelehubRotW;

                    return quat;
                }
            }
            set
            {
                m_TelehubRotX = value.X;
                m_TelehubRotY = value.Y;
                m_TelehubRotZ = value.Z;
                m_TelehubRotW = value.W;
            }
        }

        // Our Connected Telehub's SpawnPoints
        public List<Vector3> l_SpawnPoints = new List<Vector3>();

        // Add a SpawnPoint
        // ** These are not region coordinates **
        // They are relative to the Telehub coordinates
        //
        public void AddSpawnPoint(Vector3 point)
        {
            l_SpawnPoints.Add(point);
        }

        // Remove a SpawnPoint
        public void RemoveSpawnPoint(int point_index)
        {
            l_SpawnPoints.RemoveAt(point_index);
        }

        // Return the List of SpawnPoints
        public List<Vector3> SpawnPoints()
        {
            return l_SpawnPoints;

        }

        // Clear the SpawnPoints List of all entries
        public void ClearSpawnPoints()
        {
            l_SpawnPoints.Clear();
        }
    }
}
