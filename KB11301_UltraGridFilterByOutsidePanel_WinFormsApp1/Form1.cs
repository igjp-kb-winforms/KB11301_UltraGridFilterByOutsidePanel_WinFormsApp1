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

        dt.Rows.Add(new object[] { 1, "‹Ê–Ø", "‰x•v", "ç—tŒ§", "ˆ®Žs", 48 });
        dt.Rows.Add(new object[] { 2, "•ž•”", "Œõ–¾", "_“ÞìŒ§", "‰¡•lŽs¼‹æ", 52 });
        dt.Rows.Add(new object[] { 3, "‹gŒ´", "–¾—¢", "ç—tŒ§", "¼ŒËŽs", 53 });
        dt.Rows.Add(new object[] { 4, "“ñ‹{", "tŽq", "ˆïéŒ§", "í—¤‘¾“cŽs", 53 });
        dt.Rows.Add(new object[] { 5, "X’J", "Œ’ŽO˜Y", "ç—tŒ§", "ŽsŒ´Žs", 55 });
        dt.Rows.Add(new object[] { 6, "‰“ŽR", "‹I”V", "é‹ÊŒ§", "–kŠ‹üŒS¼•š’¬", 55 });
        dt.Rows.Add(new object[] { 7, "“ì", "–¾‹I", "ç—tŒ§", "–ØX’ÃŽs", 44 });
        dt.Rows.Add(new object[] { 8, "“ú”ä–ì", "³Žu", "“È–ØŒ§", "“È–ØŽs", 23 });
        dt.Rows.Add(new object[] { 9, "ã“c", "’è•v", "ŒQ”nŒ§", "ŒáÈŒS’·–ìŒ´’¬", 22 });
        dt.Rows.Add(new object[] { 10, "Î–{", "^Æ", "ˆïéŒ§", "…ŒËŽs", 46 });
        dt.Rows.Add(new object[] { 11, "‰ï“c", "á–í", "ŒQ”nŒ§", "ŠÙ—ÑŽs", 28 });
        dt.Rows.Add(new object[] { 12, "‘åŒF", "’¼Ž÷", "_“ÞìŒ§", "‰¡•lŽs¼‹æ", 20 });
        dt.Rows.Add(new object[] { 13, "¬Š}Œ´", "Ê‰Á", "“Œ‹ž“s", "¼‘½–€ŒS‰œ‘½–€’¬", 52 });
        dt.Rows.Add(new object[] { 14, "‹{‰º", "œA—S", "“È–ØŒ§", "–î”ÂŽs", 33 });
        dt.Rows.Add(new object[] { 15, "‘åÎ", "–¾‰¹", "“Œ‹ž“s", "`‹æ", 39 });
        dt.Rows.Add(new object[] { 16, "Ž›“à", "^—R”ü", "ŒQ”nŒ§", "ŠÙ—ÑŽs", 56 });
        dt.Rows.Add(new object[] { 17, "Î‰ª", "t", "“Œ‹ž“s", "`‹æ", 24 });
        dt.Rows.Add(new object[] { 18, "•x‰ª", "”ü¹", "“Œ‹ž“s", "`‹æ", 46 });
        dt.Rows.Add(new object[] { 19, "‘å‰º", "‰p°", "ˆïéŒ§", "ŒÃ‰ÍŽs", 35 });
        dt.Rows.Add(new object[] { 20, "ŽRŒû", "–ƒŽq", "ˆïéŒ§", "_²Žs", 47 });
        dt.Rows.Add(new object[] { 21, "•½–{", "N”V", "é‹ÊŒ§", "”Ñ”\Žs", 54 });
        dt.Rows.Add(new object[] { 22, "Žè“‡", "—í‰Ø", "é‹ÊŒ§", "”’‰ªŽs", 38 });
        dt.Rows.Add(new object[] { 23, "t“ú", "•Ÿ", "ç—tŒ§", "–ØX’ÃŽs", 21 });
        dt.Rows.Add(new object[] { 24, "Î‘q", "—T”V", "é‹ÊŒ§", "ã”öŽs", 29 });
        dt.Rows.Add(new object[] { 25, "H“c", "“l•É", "ŒQ”nŒ§", "‘¾“cŽs", 31 });
        dt.Rows.Add(new object[] { 26, "‘ê“c", "’C—Y", "ˆïéŒ§", "ˆî•~ŒSˆ¢Œ©’¬", 45 });
        dt.Rows.Add(new object[] { 27, "’·â", "—R—Ç", "é‹ÊŒ§", "ŽO‹½Žs", 47 });
        dt.Rows.Add(new object[] { 28, "ŒI–{", "Œcˆê", "é‹ÊŒ§", "’ßƒ–“‡Žs", 58 });
        dt.Rows.Add(new object[] { 29, "ˆäŒ´", "—˜K", "é‹ÊŒ§", "‰z’JŽs", 50 });
        dt.Rows.Add(new object[] { 30, "ìã", "—zˆê˜Y", "é‹ÊŒ§", "ƒ‘ƒŽs", 38 });
        dt.Rows.Add(new object[] { 31, "–x", "—D‰H", "“Œ‹ž“s", "ç‘ã“c‹æ", 22 });
        dt.Rows.Add(new object[] { 32, "‹{é", "•ü", "_“ÞìŒ§", "‰¡•lŽs“s’}‹æ", 56 });
        dt.Rows.Add(new object[] { 33, "âŒû", "t‰¹", "“È–ØŒ§", "“ß{‰–Œ´Žs", 22 });
        dt.Rows.Add(new object[] { 34, "’O‰H", "r—Y", "é‹ÊŒ§", "‚Ó‚¶‚Ý–ìŽs", 28 });
        dt.Rows.Add(new object[] { 35, "–Ú•", "‰Ä”¿", "ŒQ”nŒ§", "ˆÉ¨èŽs", 28 });
        dt.Rows.Add(new object[] { 36, "ˆ°“c", "F—˜", "_“ÞìŒ§", "Š™‘qŽs", 22 });
        dt.Rows.Add(new object[] { 37, "”ª–Ø", "”Žq", "_“ÞìŒ§", "ìèŽs’†Œ´‹æ", 23 });
        dt.Rows.Add(new object[] { 38, "ˆÀ‰i", "“Þ•Û”ü", "ŒQ”nŒ§", "‹Ë¶Žs", 46 });
        dt.Rows.Add(new object[] { 39, "ˆî—t", "•ÄŽq", "ŒQ”nŒ§", "‹Ë¶Žs", 56 });
        dt.Rows.Add(new object[] { 40, "¼ì", "³D", "ç—tŒ§", "–ØX’ÃŽs", 32 });
        dt.Rows.Add(new object[] { 41, "‰z’q", "˜a‰ÀŽq", "“È–ØŒ§", "²–ìŽs", 39 });
        dt.Rows.Add(new object[] { 42, "‰–Œ©", "’mŽq", "ˆïéŒ§", "‚Â‚­‚ÎŽs", 50 });
        dt.Rows.Add(new object[] { 43, "â“Œ", "“ú˜a", "ŒQ”nŒ§", "•x‰ªŽs", 32 });
        dt.Rows.Add(new object[] { 44, "¬¼", "³”ü", "“È–ØŒ§", "‰–’JŒS‰–’J’¬", 50 });
        dt.Rows.Add(new object[] { 45, "›Œ´", "‹g’j", "é‹ÊŒ§", "‚³‚¢‚½‚ÜŽs÷‹æ", 25 });
        dt.Rows.Add(new object[] { 46, "Ž›“c", "ˆè•v", "ˆïéŒ§", "“ŒˆïéŒSˆïé’¬", 39 });
        dt.Rows.Add(new object[] { 47, "¡¼", "‰hŽO˜Y", "“È–ØŒ§", "¬ŽRŽs", 36 });
        dt.Rows.Add(new object[] { 48, "’·‘ò", "¬•S‡", "“Œ‹ž“s", "Vh‹æ", 22 });
        dt.Rows.Add(new object[] { 49, "_•Û", "•—Y", "“È–ØŒ§", "“ß{‰GŽRŽs", 27 });
        dt.Rows.Add(new object[] { 50, "‰Íã", "–FŽ÷", "ˆïéŒ§", "ŽæŽèŽs", 55 });

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
            // value‚Æ“™‚µ‚¢ƒf[ƒ^‚ðœŠO‚·‚éƒtƒBƒ‹ƒ^[‚ðÝ’è‚·‚éB
            ultraGrid1.DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Add(FilterComparisionOperator.NotEquals, value);
        }
        else
        {
            // œŠOƒtƒBƒ‹ƒ^[Ý’è‚ª‚³‚ê‚Ä‚¢‚½‚ç‚»‚ê‚ðíœ‚·‚éB
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
