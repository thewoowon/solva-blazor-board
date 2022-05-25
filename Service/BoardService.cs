using SolvaBlazorBoard.Entity;

namespace SolvaBlazorBoard.Service
{
    public class BoardService
    {
        public Task<Board[]> GetBoardAsync()
        {
            return Task.FromResult(Enumerable.Range(1,10).Select(index => new Board
            {
                Date = DateTime.Now,
                Title = "",
                Html = "",
                Id = "",
            }).ToArray());
        }

        public Task<Board[]> PostBoardAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Board
            {
                Date = DateTime.Now,
                Title = "",
                Html = "",
                Id = "",
            }).ToArray());
        }
    }
}
