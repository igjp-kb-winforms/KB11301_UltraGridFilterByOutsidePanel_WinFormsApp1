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

        dt.Rows.Add(new object[] { 1, "�ʖ�", "�x�v", "��t��", "���s", 48 });
        dt.Rows.Add(new object[] { 2, "����", "����", "�_�ސ쌧", "���l�s����", 52 });
        dt.Rows.Add(new object[] { 3, "�g��", "����", "��t��", "���ˎs", 53 });
        dt.Rows.Add(new object[] { 4, "��{", "�t�q", "��錧", "�헤���c�s", 53 });
        dt.Rows.Add(new object[] { 5, "�X�J", "���O�Y", "��t��", "�s���s", 55 });
        dt.Rows.Add(new object[] { 6, "���R", "�I�V", "��ʌ�", "�k�����S������", 55 });
        dt.Rows.Add(new object[] { 7, "��", "���I", "��t��", "�؍X�Îs", 44 });
        dt.Rows.Add(new object[] { 8, "�����", "���u", "�Ȗ،�", "�Ȗ؎s", 23 });
        dt.Rows.Add(new object[] { 9, "��c", "��v", "�Q�n��", "��ȌS���쌴��", 22 });
        dt.Rows.Add(new object[] { 10, "�Ζ{", "�^��", "��錧", "���ˎs", 46 });
        dt.Rows.Add(new object[] { 11, "��c", "���", "�Q�n��", "�ٗюs", 28 });
        dt.Rows.Add(new object[] { 12, "��F", "����", "�_�ސ쌧", "���l�s����", 20 });
        dt.Rows.Add(new object[] { 13, "���}��", "�ʉ�", "�����s", "�������S��������", 52 });
        dt.Rows.Add(new object[] { 14, "�{��", "�A�S", "�Ȗ،�", "��s", 33 });
        dt.Rows.Add(new object[] { 15, "���", "����", "�����s", "�`��", 39 });
        dt.Rows.Add(new object[] { 16, "����", "�^�R��", "�Q�n��", "�ٗюs", 56 });
        dt.Rows.Add(new object[] { 17, "�Ή�", "�t��", "�����s", "�`��", 24 });
        dt.Rows.Add(new object[] { 18, "�x��", "����", "�����s", "�`��", 46 });
        dt.Rows.Add(new object[] { 19, "�剺", "�p��", "��錧", "�É͎s", 35 });
        dt.Rows.Add(new object[] { 20, "�R��", "���q", "��錧", "�_���s", 47 });
        dt.Rows.Add(new object[] { 21, "���{", "�N�V", "��ʌ�", "�є\�s", 54 });
        dt.Rows.Add(new object[] { 22, "�蓇", "���", "��ʌ�", "�����s", 38 });
        dt.Rows.Add(new object[] { 23, "�t��", "��", "��t��", "�؍X�Îs", 21 });
        dt.Rows.Add(new object[] { 24, "�Αq", "�T�V", "��ʌ�", "����s", 29 });
        dt.Rows.Add(new object[] { 25, "�H�c", "�l��", "�Q�n��", "���c�s", 31 });
        dt.Rows.Add(new object[] { 26, "��c", "�C�Y", "��錧", "��~�S������", 45 });
        dt.Rows.Add(new object[] { 27, "����", "�R��", "��ʌ�", "�O���s", 47 });
        dt.Rows.Add(new object[] { 28, "�I�{", "�c��", "��ʌ�", "�߃����s", 58 });
        dt.Rows.Add(new object[] { 29, "�䌴", "���K", "��ʌ�", "�z�J�s", 50 });
        dt.Rows.Add(new object[] { 30, "���", "�z��Y", "��ʌ�", "�����s", 38 });
        dt.Rows.Add(new object[] { 31, "�x", "�D�H", "�����s", "���c��", 22 });
        dt.Rows.Add(new object[] { 32, "�{��", "����", "�_�ސ쌧", "���l�s�s�}��", 56 });
        dt.Rows.Add(new object[] { 33, "���", "�t��", "�Ȗ،�", "�ߐ{�����s", 22 });
        dt.Rows.Add(new object[] { 34, "�O�H", "�r�Y", "��ʌ�", "�ӂ��ݖ�s", 28 });
        dt.Rows.Add(new object[] { 35, "�ڍ�", "�Ĕ�", "�Q�n��", "�ɐ���s", 28 });
        dt.Rows.Add(new object[] { 36, "���c", "�F��", "�_�ސ쌧", "���q�s", 22 });
        dt.Rows.Add(new object[] { 37, "����", "���q", "�_�ސ쌧", "���s������", 23 });
        dt.Rows.Add(new object[] { 38, "���i", "�ޕ۔�", "�Q�n��", "�ː��s", 46 });
        dt.Rows.Add(new object[] { 39, "��t", "�Ďq", "�Q�n��", "�ː��s", 56 });
        dt.Rows.Add(new object[] { 40, "����", "���D", "��t��", "�؍X�Îs", 32 });
        dt.Rows.Add(new object[] { 41, "�z�q", "�a���q", "�Ȗ،�", "����s", 39 });
        dt.Rows.Add(new object[] { 42, "����", "�m�q", "��錧", "���Ύs", 50 });
        dt.Rows.Add(new object[] { 43, "�Ⓦ", "���a", "�Q�n��", "�x���s", 32 });
        dt.Rows.Add(new object[] { 44, "����", "����", "�Ȗ،�", "���J�S���J��", 50 });
        dt.Rows.Add(new object[] { 45, "����", "�g�j", "��ʌ�", "�������܎s����", 25 });
        dt.Rows.Add(new object[] { 46, "���c", "��v", "��錧", "�����S��钬", 39 });
        dt.Rows.Add(new object[] { 47, "����", "�h�O�Y", "�Ȗ،�", "���R�s", 36 });
        dt.Rows.Add(new object[] { 48, "����", "���S��", "�����s", "�V�h��", 22 });
        dt.Rows.Add(new object[] { 49, "�_��", "���Y", "�Ȗ،�", "�ߐ{�G�R�s", 27 });
        dt.Rows.Add(new object[] { 50, "�͏�", "�F��", "��錧", "���s", 55 });

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
            // value�Ɠ������f�[�^�����O����t�B���^�[��ݒ肷��B
            ultraGrid1.DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Add(FilterComparisionOperator.NotEquals, value);
        }
        else
        {
            // ���O�t�B���^�[�ݒ肪����Ă����炻����폜����B
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
