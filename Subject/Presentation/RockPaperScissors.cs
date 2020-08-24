using Subject.Applications;
using Subject.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject.Presentation
{
    public partial class RockPaperScissors : Form
    {
        private RockPaperScissorsController rockPaperScissors;

        private AppService appService;

        private Infrastructure.XmlIO xmlIO;

        private Domain.RockPaperScissorsState rockPaperScissorsState;


        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            rockPaperScissors = new RockPaperScissorsController();

            appService = new AppService();

            xmlIO = new Infrastructure.XmlIO();

            rockPaperScissorsState = new RockPaperScissorsState();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            Hand enemyHand = appService.GetEnemyHand();

            Result? resultRock = rockPaperScissors.RockJudge(enemyHand);

            ShawResult(resultRock, appService.ConvertJapanese(enemyHand));

            appService.AddResult(resultRock);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Hand enemyHand = appService.GetEnemyHand();

            Result? resultScissors = rockPaperScissors.ScissorsJudge(enemyHand);

            ShawResult(resultScissors, appService.ConvertJapanese(enemyHand));

            appService.AddResult(resultScissors);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Hand enemyHand = appService.GetEnemyHand();

            Result? resultPaper = rockPaperScissors.PaperJudge(enemyHand);

            ShawResult(resultPaper, appService.ConvertJapanese(enemyHand));

            appService.AddResult(resultPaper);
        }

        private void ShawResult(Result? result, string enemyHand)
        {
            switch(result)
            {
                case Result.Win:
                    MessageBox.Show("あいて：" + enemyHand + Environment.NewLine + "あなたの勝ちです", "結果");
                    break;
                case Result.Losing:
                    MessageBox.Show("あいて：" + enemyHand + Environment.NewLine + "あなたの負けです", "結果");
                    break;
                case Result.Tie:
                    MessageBox.Show("あいて：" + enemyHand + Environment.NewLine + "引き分けです", "結果");
                    break;
                case null:
                    MessageBox.Show("エラーが発生しました", "システムメッセージ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string name = appService.ValidateName(txtName.Text);

            int totalRecord = appService.GetTotalRecord();

            int winRecord = appService.GetWinRecord();

            int loseRecord = appService.GetLoseRecord();

            int tieRecord = appService.GetTieRecord();

            int winRate = appService.WinRateCalculate();

            MessageBox.Show(name + "の戦績は" + Environment.NewLine +
                            totalRecord + "戦中" + Environment.NewLine +
                            winRecord + "勝" + Environment.NewLine +
                            loseRecord + "敗" + Environment.NewLine +
                            tieRecord + "分" + Environment.NewLine +
                            "勝率" + winRate + "%", "結果");
        }

        private void btnAppealingPoint_Click(object sender, EventArgs e)
        {
            var AppealingPoint = new AppealingPoint();
            // ウィンドウを表示する
            AppealingPoint.Show();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            string name = appService.ValidateName(txtName.Text);

            int totalRecord = appService.GetTotalRecord();

            int winRecord = appService.GetWinRecord();

            int loseRecord = appService.GetLoseRecord();

            int tieRecord = appService.GetTieRecord();

            rockPaperScissorsState.IsValidState(name, totalRecord, winRecord, loseRecord, tieRecord);

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "ファイルを保存";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = @"Recode.xml";
            saveFileDialog.Filter = "xmlファイル(*.xml;*.xml)|*.xml;*.xml|すべてのファイル(*.*)|*.*";

            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //「保存」ボタンが押された時の処理
                string fileName = saveFileDialog.FileName;

                xmlIO.Output(rockPaperScissorsState, fileName);


                MessageBox.Show("保存されました。", "システムメッセージ");
            }
            if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("キャンセルされました。", "システムメッセージ");
            }
        }
    }
}
