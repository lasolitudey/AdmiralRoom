﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Huoyaoyuan.AdmiralRoom.API;

namespace Huoyaoyuan.AdmiralRoom.Officer
{
    public class Material : NotifyBase
    {
        public Material()
        {
            Staff.RegisterHandler("api_get_member/material", x => GetMemberMaterial(x.Parse<getmember_material[]>().Data));
        }

        #region Fuel
        private int _fuel;
        public int Fuel
        {
            get { return _fuel; }
            set
            {
                if (_fuel != value)
                {
                    _fuel = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Bull
        private int _bull;
        public int Bull
        {
            get { return _bull; }
            set
            {
                if (_bull != value)
                {
                    _bull = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Steel
        private int _steel;
        public int Steel
        {
            get { return _steel; }
            set
            {
                if (_steel != value)
                {
                    _steel = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Bauxite
        private int _bauxite;
        public int Bauxite
        {
            get { return _bauxite; }
            set
            {
                if (_bauxite != value)
                {
                    _bauxite = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region InstantBuild
        private int _instantbuild;
        public int InstantBuild
        {
            get { return _instantbuild; }
            set
            {
                if (_instantbuild != value)
                {
                    _instantbuild = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region InstantRepair
        private int _instantrepail;
        public int InstantRepair
        {
            get { return _instantrepail; }
            set
            {
                if (_instantrepail != value)
                {
                    _instantrepail = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region DevelopmentKit
        private int _developmentkit;
        public int DevelopmentKit
        {
            get { return _developmentkit; }
            set
            {
                if (_developmentkit != value)
                {
                    _developmentkit = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region ImprovementKit
        private int _improvementkit;
        public int ImprovementKit
        {
            get { return _improvementkit; }
            set
            {
                if (_improvementkit != value)
                {
                    _improvementkit = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        public void GetMemberMaterial(getmember_material[] api)
        {
            if (api == null) return;
            foreach(var mat in api)
            {
                switch (mat.api_id)
                {
                    case 1:
                        Fuel = mat.api_value;
                        break;
                    case 2:
                        Bull = mat.api_value;
                        break;
                    case 3:
                        Steel = mat.api_value;
                        break;
                    case 4:
                        Bauxite = mat.api_value;
                        break;
                    case 5:
                        InstantBuild = mat.api_value;
                        break;
                    case 6:
                        InstantRepair = mat.api_value;
                        break;
                    case 7:
                        DevelopmentKit = mat.api_value;
                        break;
                    case 8:
                        ImprovementKit = mat.api_value;
                        break;
                }
            }
        }
    }
}
