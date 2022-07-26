using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NotesApp.Models
{
    public class Note
    {
        public int NoteId { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }
        public string Status { set; get; }

    }
}
