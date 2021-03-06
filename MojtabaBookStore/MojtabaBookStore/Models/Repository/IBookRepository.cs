﻿using MojtabaBookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojtabaBookStore.Models.Repository
{
    public interface IBookRepository
    {
        List<TreeViewCategory> GetAllCategories();
        void BindSubCategories(TreeViewCategory category);
        List<BooksIndexViewModel> GetAllBooks(string title, string ISBN, string Language, string Publisher, string Author, string Translator, string Category);
    }
}
