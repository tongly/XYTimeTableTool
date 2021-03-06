﻿using OSKernel.Presentation.Core;
using OSKernel.Presentation.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Unity;
namespace OSKernel.Presentation.Arranging.Mixed.Modify.Algo.ClassHour
{
    /// <summary>
    /// 单个课时有多个优先开始时间、单个课时有多个优先课位
    /// </summary>
    public partial class ClassHoursRequiredTimes : UserControl
    {
        public ClassHoursRequiredTimes()
        {
            InitializeComponent();
            this.DataContext = CacheManager.Instance.UnityContainer.Resolve<ClassHoursRequiredTimesModel>();
        }

        public ClassHoursRequiredTimes(MixedAlgoRuleEnum ruleEnum) : this()
        {
            (this.DataContext as ClassHoursRequiredTimesModel).BindData(ruleEnum);
        }
    }
}
