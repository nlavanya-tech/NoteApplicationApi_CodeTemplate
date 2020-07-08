using MongoDB.Driver;
using NoteApplicationApi.DataLayer.Context;
using NoteApplicationApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteApplicationApi.BusinessLayer.Services.Repository
{
   public class NoteRepository:INoteRepository
    {
        private readonly IMongoDbContext _context;
        public NoteRepository(IMongoDbContext context)
        {
            _context = context;
        }
        //Get call from Noteservice to read all Notes from Mongo DB
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
            try
            {
                var notes = await _context.notes.Find(note => true).ToListAsync();
                return notes;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //Get call from Noteservice to read Notes based on id from Mongo DB
        public async Task<Notes> ReadIdAsync(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        //Get call from Noteservice to Create Note from Mongo DB
        public async Task<Notes> CreateAsync(Notes notes)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        //Get call from Noteservice to Update Note Based on Id from Mongo DB
        public async Task<Notes> UpdateAsync(int id ,Notes notes)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        //Get call from Noteservice to Create Note Based on Id from Mongo DB
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}
