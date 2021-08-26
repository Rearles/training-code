using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoteTakingApp.DataAccess.Entities;
using NoteTakingApp.Domain;

namespace NoteTakingApp.DataAccess
{
    public class Repository : IRepository
    {
        private readonly NotesDbContext _context;

        public Repository(NotesDbContext context)
        {
            _context = context;
        }

        public List<Domain.Note> GetNotes()
        {
            return _context.Notes
                .Include(n => n.NoteTags)
                .Select(n => new Domain.Note
                {
                    Id = n.Id,
                    Text = n.Text,
                    Tags = n.NoteTags.Select(nt => nt.Name).ToList()
                })
                .ToList();
            // (the LINQ way of doing in one line the below code:)

            //var entities = _context.Notes
            //    .Include(n => n.NoteTags)
            //    .ToList();

            //var notes = new List<Domain.Note>();
            //foreach (var entity in entities)
            //{
            //    var note = new Domain.Note
            //    {
            //        Id = entity.Id,
            //        Text = entity.Text
            //    };
            //    foreach (var noteTag in entity.NoteTags)
            //    {
            //        note.Tags.Add(noteTag.Name);
            //    }
            //}
        }

        public List<Domain.Note> GetNotesWithTag(string tag)
        {
            return null;
        }

        public Domain.Note AddNote(Domain.Note note)
        {
            return null;
        }
    }
}
