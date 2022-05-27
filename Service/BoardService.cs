using SolvaBlazorBoard.Entity;
using SolvaBlazorBoard.Models;
using System.Security.Cryptography;


namespace SolvaBlazorBoard.Service
{
    public class BoardService
    {

        SOLVAAGORAContext context;

        public SOLVAAGORAContext Context
        {
            get { return context; }
        }
        public BoardService()
        {
            context = new SOLVAAGORAContext();
        }


        public Task<TblAgoraBoardMaster[]> GetBoardAsync()
        {
            TblAgoraBoardMaster[] boardMasters;
            TblAgoraTagMaster[] tagMasters;
            TblAgoraFileMaster[] fileMasters;

            boardMasters = (from e in Context.TblAgoraBoardMasters
                        select e).ToArray();

            return Task.FromResult(boardMasters);
        }

        public async Task AddBoardAsync(TblAgoraBoardMaster boardMaster)
        {
            string hashId = Guid.NewGuid().ToString();
            boardMaster.Id = hashId; // 해쉬 알고리즘으로 고유값 생성 중복 확률 아주 낮음..미미

            await this.Context.TblAgoraBoardMasters.AddAsync(boardMaster);
            this.Context.SaveChanges();
        }
    }
}
