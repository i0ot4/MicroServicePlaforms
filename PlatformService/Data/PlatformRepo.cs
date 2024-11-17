using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        #region Feilds
        private readonly AppDbContext _context;

        #endregion

        #region Constructors
        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        #endregion


        public void CreatePlatform(Platform Item)
        {
            _context.platforms.Add(Item);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            var data = _context.platforms.ToList();
            return data;
        }

        public Platform GetPlatformById(int Id)
        {
            var data = _context.platforms.FirstOrDefault(x => x.Id == Id);
            return data;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }


}
