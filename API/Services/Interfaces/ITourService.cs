﻿using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Interfaces;

public interface ITourService
{ 
    Task<List<Tour>> GetAllToursAsync();
    
    Task<ActionResult<Tour>> GetTourByIdAsync(int id);
}