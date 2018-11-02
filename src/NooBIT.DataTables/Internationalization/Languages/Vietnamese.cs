namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Vietnamese : NamedLanguageSettings
    {
        internal Vietnamese() : base("vi")
        {
            EmptyTable = null;
            Info = $"Đang xem {START} đến {END} trong tổng số {TOTAL} mục";
            InfoEmpty = "Đang xem 0 đến 0 trong tổng số 0 mục";
            InfoFiltered = $"(được lọc từ {MAX} mục)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Xem {MENU} mục";
            LoadingRecords = null;
            Processing = "Đang xử lý...";
            Search = "Tìm:";
            ZeroRecords = "Không tìm thấy dòng nào phù hợp";
            Paginate = new Paginate
            {
                First = "Đầu",
                Previous = "Trước",
                Next = "Tiếp",
                Last = "Cuối",
            };
        }
    }
}

