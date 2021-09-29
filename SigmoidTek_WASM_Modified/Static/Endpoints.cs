namespace SigmoidTek_WASM_Modified.Static;
public class Endpoints
{
    public static string BaseUrl = "https://localhost:7027";

    public static string UrlGetAllAngajati(int currentPage, int pageSize)
    {
        return $"/api/Pagination?currentPageNumber={currentPage}&pageSize={pageSize}";
    }
}

