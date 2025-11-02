using System;
using Microsoft.EntityFrameworkCore;

namespace backend.Models;

public class AppDbcontext :DbContext
{
public AppDbcontext(DbcontextOptions<AppDbcontext> options)
{
    
}
}
