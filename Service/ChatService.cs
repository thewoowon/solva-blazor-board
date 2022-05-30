using SolvaBlazorBoard.Entity;
using SolvaBlazorBoard.Models;
namespace SolvaBlazorBoard.Service
{
    public class ChatService
    {
        SOLVAAGORAContext context;

        public SOLVAAGORAContext Context
        {
            get { return context; }
        }
        public ChatService()
        {
            context = new SOLVAAGORAContext();
        }

        public Task<TblAgoraChatMaster[]> GetChatAsync()
        {
            TblAgoraChatMaster[] chatMasters;
            TblAgoraTagMaster[] tagMasters;
            TblAgoraFileMaster[] fileMasters;

            chatMasters = (from e in Context.TblAgoraChatMasters
                            select e).ToArray();

            return Task.FromResult(chatMasters);
        }

        public async Task AddChatAsync(TblAgoraChatMaster chatMaster)
        {
            string hashId = Guid.NewGuid().ToString();
            chatMaster.Id = hashId; // 해쉬 알고리즘으로 고유값 생성 중복 확률 아주 낮음..미미

            await this.Context.TblAgoraChatMasters.AddAsync(chatMaster);
            this.Context.SaveChanges();
        }

    }
}
