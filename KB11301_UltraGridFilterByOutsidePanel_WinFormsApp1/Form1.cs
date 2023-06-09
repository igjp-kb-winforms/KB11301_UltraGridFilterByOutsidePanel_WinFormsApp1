using Infragistics.Win.UltraWinGrid;
using System.Data;

namespace KB11301_UltraGridFilterByOutsidePanel_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ultraGrid1.DataSource = GetPeopleData();
    }

    private DataTable GetPeopleData()
    {
        DataTable dt = new DataTable();

        var idColumn = dt.Columns.Add("ID", typeof(int));
        dt.Columns.Add("FamilyName", typeof(String));
        dt.Columns.Add("GivenName", typeof(String));
        dt.Columns.Add("Prefecture", typeof(String));
        dt.Columns.Add("City", typeof(String));
        dt.Columns.Add("Age", typeof(int));

        dt.Rows.Add(new object[] { 1, "玉木", "悦夫", "千葉県", "旭市", 48 });
        dt.Rows.Add(new object[] { 2, "服部", "光明", "神奈川県", "横浜市西区", 52 });
        dt.Rows.Add(new object[] { 3, "吉原", "明里", "千葉県", "松戸市", 53 });
        dt.Rows.Add(new object[] { 4, "二宮", "春子", "茨城県", "常陸太田市", 53 });
        dt.Rows.Add(new object[] { 5, "森谷", "健三郎", "千葉県", "市原市", 55 });
        dt.Rows.Add(new object[] { 6, "遠山", "紀之", "埼玉県", "北葛飾郡松伏町", 55 });
        dt.Rows.Add(new object[] { 7, "南", "明紀", "千葉県", "木更津市", 44 });
        dt.Rows.Add(new object[] { 8, "日比野", "正志", "栃木県", "栃木市", 23 });
        dt.Rows.Add(new object[] { 9, "上田", "定夫", "群馬県", "吾妻郡長野原町", 22 });
        dt.Rows.Add(new object[] { 10, "石本", "真哉", "茨城県", "水戸市", 46 });
        dt.Rows.Add(new object[] { 11, "会田", "雪弥", "群馬県", "館林市", 28 });
        dt.Rows.Add(new object[] { 12, "大熊", "直樹", "神奈川県", "横浜市西区", 20 });
        dt.Rows.Add(new object[] { 13, "小笠原", "彩加", "東京都", "西多摩郡奥多摩町", 52 });
        dt.Rows.Add(new object[] { 14, "宮下", "廣祐", "栃木県", "矢板市", 33 });
        dt.Rows.Add(new object[] { 15, "大石", "明音", "東京都", "港区", 39 });
        dt.Rows.Add(new object[] { 16, "寺内", "真由美", "群馬県", "館林市", 56 });
        dt.Rows.Add(new object[] { 17, "石岡", "春香", "東京都", "港区", 24 });
        dt.Rows.Add(new object[] { 18, "富岡", "美沙", "東京都", "港区", 46 });
        dt.Rows.Add(new object[] { 19, "大下", "英晴", "茨城県", "古河市", 35 });
        dt.Rows.Add(new object[] { 20, "山口", "麻子", "茨城県", "神栖市", 47 });
        dt.Rows.Add(new object[] { 21, "平本", "康之", "埼玉県", "飯能市", 54 });
        dt.Rows.Add(new object[] { 22, "手島", "麗華", "埼玉県", "白岡市", 38 });
        dt.Rows.Add(new object[] { 23, "春日", "福", "千葉県", "木更津市", 21 });
        dt.Rows.Add(new object[] { 24, "石倉", "裕之", "埼玉県", "上尾市", 29 });
        dt.Rows.Add(new object[] { 25, "秋田", "斗碧", "群馬県", "太田市", 31 });
        dt.Rows.Add(new object[] { 26, "滝田", "辰雄", "茨城県", "稲敷郡阿見町", 45 });
        dt.Rows.Add(new object[] { 27, "長坂", "由良", "埼玉県", "三郷市", 47 });
        dt.Rows.Add(new object[] { 28, "栗本", "慶一", "埼玉県", "鶴ヶ島市", 58 });
        dt.Rows.Add(new object[] { 29, "井原", "利幸", "埼玉県", "越谷市", 50 });
        dt.Rows.Add(new object[] { 30, "川上", "陽一郎", "埼玉県", "鴻巣市", 38 });
        dt.Rows.Add(new object[] { 31, "堀", "優羽", "東京都", "千代田区", 22 });
        dt.Rows.Add(new object[] { 32, "宮城", "朋香", "神奈川県", "横浜市都筑区", 56 });
        dt.Rows.Add(new object[] { 33, "坂口", "春音", "栃木県", "那須塩原市", 22 });
        dt.Rows.Add(new object[] { 34, "丹羽", "俊雄", "埼玉県", "ふじみ野市", 28 });
        dt.Rows.Add(new object[] { 35, "目黒", "夏帆", "群馬県", "伊勢崎市", 28 });
        dt.Rows.Add(new object[] { 36, "芦田", "孝利", "神奈川県", "鎌倉市", 22 });
        dt.Rows.Add(new object[] { 37, "八木", "数子", "神奈川県", "川崎市中原区", 23 });
        dt.Rows.Add(new object[] { 38, "安永", "奈保美", "群馬県", "桐生市", 46 });
        dt.Rows.Add(new object[] { 39, "稲葉", "米子", "群馬県", "桐生市", 56 });
        dt.Rows.Add(new object[] { 40, "松川", "正好", "千葉県", "木更津市", 32 });
        dt.Rows.Add(new object[] { 41, "越智", "和佳子", "栃木県", "佐野市", 39 });
        dt.Rows.Add(new object[] { 42, "塩見", "知子", "茨城県", "つくば市", 50 });
        dt.Rows.Add(new object[] { 43, "坂東", "日和", "群馬県", "富岡市", 32 });
        dt.Rows.Add(new object[] { 44, "小松", "正美", "栃木県", "塩谷郡塩谷町", 50 });
        dt.Rows.Add(new object[] { 45, "菅原", "吉男", "埼玉県", "さいたま市桜区", 25 });
        dt.Rows.Add(new object[] { 46, "寺田", "郁夫", "茨城県", "東茨城郡茨城町", 39 });
        dt.Rows.Add(new object[] { 47, "今西", "栄三郎", "栃木県", "小山市", 36 });
        dt.Rows.Add(new object[] { 48, "長沢", "小百合", "東京都", "新宿区", 22 });
        dt.Rows.Add(new object[] { 49, "神保", "武雄", "栃木県", "那須烏山市", 27 });
        dt.Rows.Add(new object[] { 50, "河上", "芳樹", "茨城県", "取手市", 55 });

        dt.PrimaryKey = new DataColumn[] { idColumn };

        return dt;
    }

    private void prefectureCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox checkBox = (CheckBox)sender;
        updateCheckBoxFilter("Prefecture", checkBox, checkBox.Text);
    }

    private void updateCheckBoxFilter(String columnName, CheckBox checkBox, string value)
    {
        if (!checkBox.Checked)
        {
            // valueと等しいデータを除外するフィルターを設定する。
            ultraGrid1.DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Add(FilterComparisionOperator.NotEquals, value);
        }
        else
        {
            // 除外フィルター設定がされていたらそれを削除する。
            FilterCondition[] filterConditions = new FilterCondition[ultraGrid1.DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Count];
            ultraGrid1.DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.CopyTo(filterConditions, 0);
            var filterCondition = filterConditions.FirstOrDefault(condition => condition.CompareValue.ToString() == value);
            if (filterCondition != null)
            {
                ultraGrid1.DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Remove(filterCondition);
            }
        }
    }

}
