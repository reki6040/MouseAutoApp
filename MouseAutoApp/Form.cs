using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
/*
 * MouseAutoAppの目的はWindowsにおけるスクリーンセーバーを手動で無効化し続けるためにMouseを一定間隔で動作させ続ける[座標 x=0,y=0なので目に見える動きはない]
 * ために存在している。
 */
namespace MouseAutoApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        // 追加 Start
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(
            uint nInputs,       //INPUT構造体の数
            INPUT[] pInputs,    //INPUT構造体
            int cbSize);        //INPUT構造体のサイズ
        [StructLayout(LayoutKind.Sequential)]
        struct INPUT    
        {
            public int type;        // 0:MOUSE 1:KEYBOARD
            public MOUSEINPUT mi;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT   
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }
        INPUT[] input = new INPUT[1];//イベントはMouse用に1個だけ
        // 追加 End
        public Form()
        {
            //Designerの初期化
            InitializeComponent();
            //タイマの初期設定
            OneMiniteTimer.Interval = 30000;//30秒間隔
            //タイマ値の入力用のテキストボックスにタイマ値初期値設定
            TimeIntervalTextBox.Text = Convert.ToString(OneMiniteTimer.Interval);
            //タイマ値の入力用のテキストボックスに桁数の入力制限[11桁=2147483647まで]
            TimeIntervalTextBox.MaxLength = 11;
            OneMiniteTimer.Enabled  = false;//タイマ実行off
            //ボタンのテキスト表示
            BootOnOff.Text = "Timer Start";  //タイマストップ
        }

        private void BootOnOff_Click(object sender, EventArgs e)
        {
            string numericString = string.Empty;
            ulong tmp_numeric = 0;

            if (BootOnOff.Text == "Timer Stop")
            {
                BootOnOff.Text = "Timer Start";
                OneMiniteTimer.Enabled = false;
            }
            else
            {
                numericString =TimeIntervalTextBox.Text;
                tmp_numeric = Convert.ToUInt64(numericString);
                //32bitの2147483647以上の場合はデフォルトの30秒へ戻すようにフェールセーフを入れている。
                if (tmp_numeric < (ulong)Int32.MaxValue)
                {
                    OneMiniteTimer.Interval = (Int32)tmp_numeric;
                }
                else
                {
                    OneMiniteTimer.Interval = 30000;
                }
                BootOnOff.Text = "Timer Stop";
                OneMiniteTimer.Enabled = true;
            }
            //ボタン押下後は値を行進
            TimeIntervalTextBox.Text = Convert.ToString(OneMiniteTimer.Interval);
        }

        private void OneMiniteTimer_Tick(object sender, EventArgs e)
        {
            input[0].mi.dwFlags = 0x0001;//MOUSEEVENTF_MOVE
            //input[0].mi.dx = 100;     //Mouseの座標:xの移動動作確認用
            //input[0].mi.dy = 100;     //Mouseの座標:yの移動動作確認用
            SendInput(1, input, Marshal.SizeOf(input[0]));
        }

        private void TimeIntervalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数字以外入力禁止
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // メッセージボックスでアプリのバージョンの表示する
            MessageBox.Show("Version: 1.0.0 ");
        }
    }
}
