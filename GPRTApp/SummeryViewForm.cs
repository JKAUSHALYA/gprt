using GPRTCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRTApp
{
    public partial class SummeryViewForm : Form
    {
        private List<Level> levels;
        public SummeryViewForm(List<Level> levels)
        {
            this.levels = levels;
            InitializeComponent();
        }

        private void SummeryViewForm_Load(object sender, EventArgs e)
        {
            var level4Result = CalculateLevelResult(levels.Single(lvl => lvl.LevelName.Equals("Level4")));
            var level5Result = CalculateLevelResult(levels.Single(lvl => lvl.LevelName.Equals("Level5")));
            var level6Result = CalculateLevelResult(levels.Single(lvl => lvl.LevelName.Equals("Level6")));

            dataGridView1.Rows.Add(level4Result.Level.LevelName, level4Result.TotalCredits, level4Result.ResultStatus);
            dataGridView1.Rows.Add(level5Result.Level.LevelName, level5Result.TotalCredits, level5Result.ResultStatus);
            dataGridView1.Rows.Add(level6Result.Level.LevelName, level6Result.TotalCredits, level6Result.ResultStatus);

            bool everyLevelPassed = true;

            if (level4Result.ResultStatus == GPRTCommon.Result.Status.PASS)
            {
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Green;
            }
            else
            {
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                everyLevelPassed = false;
            }

            if (level5Result.ResultStatus == GPRTCommon.Result.Status.PASS)
            {
                dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Green;
            }
            else
            {
                dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Red;
                everyLevelPassed = false;
            }

            if (level6Result.ResultStatus == GPRTCommon.Result.Status.PASS)
            {
                dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.Green;
            }
            else
            {
                dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.Red;
                everyLevelPassed = false;
            }

            var level5Lowest = level5Result.ModuleResults.OrderBy(mr => mr.Mark).ToList()[0];
            var level6Lowest = level6Result.ModuleResults.OrderBy(mr => mr.Mark).ToList()[0];

            if (level5Lowest.Mark == level6Lowest.Mark)
            {
                if (level6Lowest.Credits == 40)
                {
                    level6Lowest.Credits = 20;
                } else
                {
                    level6Result.ModuleResults.Remove(level6Lowest);
                }
            } else
            {
                if (level5Lowest.Mark < level6Lowest.Mark)
                {
                    if (level5Lowest.Credits == 40)
                    {
                        level5Lowest.Credits = 20;
                    }
                    else
                    {
                        level5Result.ModuleResults.Remove(level5Lowest);
                    }
                } else
                {
                    if (level6Lowest.Credits == 40)
                    {
                        level6Lowest.Credits = 20;
                    }
                    else
                    {
                        level6Result.ModuleResults.Remove(level6Lowest);
                    }
                }
            }

            var level5Grade = (level5Result.ModuleResults
                .Sum(mr => mr.Mark * mr.Credits)
                / level5Result.ModuleResults.Sum(mr => mr.Credits))
                * (decimal)(1.0/3.0);

            var level6Grade = (level6Result.ModuleResults
                .Sum(mr => mr.Mark * mr.Credits)
                / level6Result.ModuleResults.Sum(mr => mr.Credits))
                * (decimal)(2.0/3.0);

            var finalGrade = level5Grade + level6Grade;
            
            if (finalGrade >= 70 && everyLevelPassed)
            {
                finalResultLbl.Text = "First Class Honurs";
                finalResultLbl.ForeColor = Color.Green;
            } else if (finalGrade > 60 && everyLevelPassed)
            {
                finalResultLbl.Text = "Second Class Honurs Upper Division";
                finalResultLbl.ForeColor = Color.Green;
            } else if (finalGrade > 50 && everyLevelPassed)
            {
                finalResultLbl.Text = "Second Class Lower Division";
                finalResultLbl.ForeColor = Color.Green;
            } else if (finalGrade > 40 && everyLevelPassed)
            {
                finalResultLbl.Text = "Third Class Honurs";
                finalResultLbl.ForeColor = Color.Green;
            } else
            {
                finalResultLbl.Text = "FAIL";
                finalResultLbl.ForeColor = Color.Red;
            }
        }

        private LevelResult CalculateLevelResult(Level level)
        {
            var levelResult = new LevelResult();
            levelResult.ResultStatus = GPRTCommon.Result.Status.PASS;

            var moduleResults = new List<ModuleResult>();
            foreach (var module in level.Modules)
            {
                var moduleResult = CalculateModuleResult(module);
                levelResult.TotalCredits += moduleResult.Credits;
                moduleResults.Add(moduleResult);
            }

            if (levelResult.TotalCredits < 120)
            {
                levelResult.ResultStatus = GPRTCommon.Result.Status.FAIL;
            }

            levelResult.Level = level;
            levelResult.ModuleResults = moduleResults;
            return levelResult;
        }

        private ModuleResult CalculateModuleResult(Module module)
        {
            var moduleResult = new ModuleResult();
            moduleResult.ResultStatus = GPRTCommon.Result.Status.PASS;
            moduleResult.Credits = Convert.ToInt32(module.CreditValue);

            var assesmentResults = new List<AssesmentResult>();
            foreach (var assesment in module.Assesments)
            {
                var assesmentResult = CalculateAssementResult(assesment);
                assesmentResults.Add(assesmentResult);
            }

            moduleResult.Mark = assesmentResults.Sum(ar => Convert.ToDecimal(ar.Assesment.ActualMark)) 
                / assesmentResults.Count;

            if (assesmentResults.Any(ar => ar.ResultStatus == GPRTCommon.Result.Status.FAIL) 
                || moduleResult.Mark < 30)
            {
                moduleResult.ResultStatus = GPRTCommon.Result.Status.FAIL;
                moduleResult.Credits = 0;
            }

            moduleResult.Module = module;
            moduleResult.AssesmentResults = assesmentResults;
            return moduleResult;
        }

        private AssesmentResult CalculateAssementResult(Assesment assesment)
        {
            var assesmentResult = new AssesmentResult();
            var mark = 0;

            if (assesment.ActualMark != null && assesment.ActualMark != "")
            {
                mark = Convert.ToInt32(assesment.ActualMark);
            } else if (assesment.PredictedMark != null && assesment.PredictedMark != "")
            {
                mark = Convert.ToInt32(assesment.PredictedMark);
            }

            if (mark > 30)
            {
                assesmentResult.ResultStatus = GPRTCommon.Result.Status.PASS;
            } else
            {
                assesmentResult.ResultStatus = GPRTCommon.Result.Status.FAIL;
            }

            assesmentResult.Assesment = assesment;
            return assesmentResult;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
