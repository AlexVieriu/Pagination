namespace AshProgHelp_WASM_Modified.Models
{
    public class Pagination<T> where T : class
    {
        public List<T>? Data { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPageNumber { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
