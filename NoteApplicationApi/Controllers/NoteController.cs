﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteApplicationApi.BusinessLayer.Interface;
using NoteApplicationApi.Entities;

namespace NoteApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _service;
        public NoteController(INoteService service)
        {
            _service = service;
        }
        // GET: api/Note
        //This Method Gets Request Call from User to Read Notes.
        [HttpGet]
        public async Task<IEnumerable<Notes>> GetAllNotes()
        {
            var notes = await _service.ReadAsync();
            return notes;
        }
        // POST: api/Notes
        //This Method Gets Request Call from User to Create Notes.
        [HttpPost]
        public async void SubmitNotes([FromBody] Notes notes)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Notes/5
        //This Method Gets Request Call from User to Update Notes.
        [HttpPut("{id}")]
        public async void UpdateNotes(int id, [FromBody] Notes notes)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/ApiWithActions/5
        //This Method Gets Request Call from User to Delete Notes.
        [HttpDelete("{id}")]
        public async void DeleteNotes(int id)
        {
            throw new NotImplementedException();
        }
    }
}
