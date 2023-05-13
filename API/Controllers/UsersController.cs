﻿using Domain.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class UsersController : BaseApiController
{
    private readonly IUserService _userService;
    
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]//api/users 
    public async Task<ActionResult<List<User>>> GetUsers()
    {
        return await _userService.GetAllUsersAsync();
    }

    /*[HttpGet("{id}")]//api/users/fdsfdsf
    public async Task<ActionResult<User>> GetUser(Guid id)
    {
        return await _context.Users.FindAsync(id);
    }*/
    
    /*[HttpGet("~/find")]//api/byName
    public async Task<ActionResult<User>> FindForName(string name)
    {
        return await _context.Users.FindAsync(_context.Users.Where(u =>u.Id==name).ToList());
    }*/
}