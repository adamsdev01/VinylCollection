using Microsoft.EntityFrameworkCore;
using VinylCollection.Data.Models;

namespace VinylCollection.Data
{
    public class VinylRecordsService
    {
        readonly VinylCollectionDbContext _dbContext = new();

        public VinylRecordsService(VinylCollectionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// To Get all VinylRecords
        /// </summary>
        /// <returns></returns>
        public List<VinylRecord> GetVinylRecords()
        {
            try
            {
                return _dbContext.VinylRecords.ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// To Add new VinylRecord record
        /// </summary>
        /// <param name="VinylRecord"></param>
        public void AddVinylRecord(VinylRecord VinylRecord)
        {
            try
            {
                _dbContext.VinylRecords.Add(VinylRecord);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// To Update the records of a particluar VinylRecord
        /// </summary>
        /// <param name="VinylRecord"></param>
        public void UpdateVinylRecordDetails(VinylRecord VinylRecord)
        {
            try
            {
                _dbContext.Entry(VinylRecord).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get the details of a particular VinylRecord
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VinylRecord GetVinylRecordData(int id)
        {
            try
            {
                VinylRecord? VinylRecord = _dbContext.VinylRecords.Find(id);
                if (VinylRecord != null)
                {
                    return VinylRecord;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// To Delete the record of a particular VinylRecord
        /// </summary>
        /// <param name="id"></param>
        public void DeleteVinylRecord(int id)
        {
            try
            {
                VinylRecord? VinylRecord = _dbContext.VinylRecords.Find(id);
                if (VinylRecord != null)
                {
                    _dbContext.VinylRecords.Remove(VinylRecord);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
