namespace AshProgHelp_WASM_Modified.Static
{
    public static class EndPoints
    {
        public static string BaseUrl { get; set; } = "https://localhost:7027";

        public static string URLGetAll(int currentPage, int pageSize)
        {
            return $"/api/Pagination?currentPageNumber={currentPage}&pageSize={pageSize}"; 
        }
    }
}
