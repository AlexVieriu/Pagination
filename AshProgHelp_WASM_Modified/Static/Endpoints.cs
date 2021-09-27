namespace AshProgHelp_WASM_Modified.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = $"https://localhost:7027";

        public static string URLGetAllAngajati(int currentPage, int pageSize)
        {
            return $"/api/Pagination?currentPageNumber={currentPage}&pageSize={pageSize}";
        }
    }
}
