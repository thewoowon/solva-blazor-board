using SolvaBlazorBoard.Entity;
using SolvaBlazorBoard.Models;
namespace SolvaBlazorBoard.Service
{
    public class NewsService
    {
        SOLVAAGORAContext context;

        public SOLVAAGORAContext Context
        {
            get { return context; }
        }
        public NewsService()
        {
            context = new SOLVAAGORAContext();
        }

        public Task<TblAgoraNewsMaster[]> GetNewsAsync()
        {
            TblAgoraNewsMaster[] newsMasters;
            TblAgoraTagMaster[] tagMasters;
            TblAgoraFileMaster[] fileMasters;
         
            newsMasters = (from e in Context.TblAgoraNewsMasters
                           select e).ToArray();

            return Task.FromResult(newsMasters);
        }

        public async Task AddNewsAsync(TblAgoraNewsMaster newsMaster)
        {
            string hashId = Guid.NewGuid().ToString();
            newsMaster.Id = hashId; // 해쉬 알고리즘으로 고유값 생성 중복 확률 아주 낮음..미미

            await this.Context.TblAgoraNewsMasters.AddAsync(newsMaster);
            this.Context.SaveChanges();
        }
    }
}
