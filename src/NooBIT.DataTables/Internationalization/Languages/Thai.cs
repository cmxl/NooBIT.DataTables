namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Thai : NamedLanguageSettings
    {
        internal Thai() : base("th")
        {
            EmptyTable = "ไม่มีข้อมูลในตาราง";
            Info = $"แสดง {START} ถึง {END} จาก {TOTAL} แถว";
            InfoEmpty = "แสดง 0 ถึง 0 จาก 0 แถว";
            InfoFiltered = $"(กรองข้อมูล {MAX} ทุกแถว)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"แสดง {MENU} แถว";
            LoadingRecords = "กำลังโหลดข้อมูล...";
            Processing = "กำลังดำเนินการ...";
            Search = "ค้นหา: ";
            ZeroRecords = "ไม่พบข้อมูล";
            Paginate = new Paginate
            {
                First = "หน้าแรก",
                Previous = "ก่อนหน้า",
                Next = "ถัดไป",
                Last = "หน้าสุดท้าย",
            };
            Aria = new Aria
            {
                SortAscending = ": เปิดใช้งานการเรียงข้อมูลจากน้อยไปมาก",
                SortDescending = ": เปิดใช้งานการเรียงข้อมูลจากมากไปน้อย",
            };
        }
    }
}

