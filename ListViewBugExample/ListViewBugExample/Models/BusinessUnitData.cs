using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ExecutiveReportingXamarinInfrastructure.Models
{
    public class BusinessUnitData
    {
        public string CompanieswithGraph { get; set; }
        public string PeriodWeek{ get; set; }
        public List<JKIBusinessUnit> businessUnits{ get; set; }
        public DataRange[] dataRangePTD{ get; set; }
        public DataRange[] dataRangeYTD{ get; set; }
    }

    public partial class JKIBusinessUnit : BindableBase
    {
        public string businessUnitName{ get; set; }
        public string businessUnitAcroynm{ get; set; }
        public string businessUnitLogo{ get; set; }
        private bool _isSelected = false;
        public bool IsSelected { get=>_isSelected; 
            set { 
                SetProperty(ref _isSelected, value); 
            } 
        }
        public Metric[] metrics{ get; set; }
    }

    public class Metric
    {
        public string metricName{ get; set; }
        public string metricType{ get; set; }
        public DateTime metricRecordDate{ get; set; }
        public int drilldownLevel{ get; set; }
        public MetricMeasurement[] metricMeasurements{ get; set; }
        public MetricMeasurement Measurement { get => metricMeasurements?.FirstOrDefault() ?? new MetricMeasurement(); }
        public Metric[] metrics{ get; set; }
        public DataPoint[] dataPointsYTD{ get; set; }
        public DataPoint[] dataPointsPTD{ get; set; }
        public DataPointTotal totals{ get; set; }

    }

    public class MetricMeasurement
    {
        public string metricMeasurementAcronym{ get; set; }
        public string title{ get; set; }
        public string metricScale{ get; set; }
        public string metricHiLo{ get; set; }
        public string metricTarget{ get; set; }
        public string metricActual{ get; set; }
        public string metricBudget{ get; set; }
        public string metricVariance{ get; set; }
        public string metricDetail{ get; set; }
    }

    public class DataRange
    {
        public string scaleNum{ get; set; }
        public string range{ get; set; }
    }

    public class DataPoint
    {
        public string scaleNum{ get; set; }
        public string recordDate{ get; set; }
        public string expectedValue{ get; set; }
        public string actualValue{ get; set; }
    }

    public class PeriodWeek
    {
        public int Period{ get; set; }
        public long Week{ get; set; }
    }
    public class DataPointTotal
    {
        public string actualPTD{ get; set; }
        public string expectedPTD{ get; set; }
        public string actualYTD{ get; set; }
        public string expectedYTD{ get; set; }
    }
}
