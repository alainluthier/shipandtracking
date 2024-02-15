using System;
using System.Collections.Generic;
using System.Linq;
using ShipAndTrack.Models;
using ShipAndTrack.Data;
using Microsoft.EntityFrameworkCore;
namespace ShipAndTrack.Services
{
    public class PackageService{
        private readonly ShipAndTrackContext _context;

        public PackageService(ShipAndTrackContext context){
            _context=context;
        }
        public async Task<List<Package>> GetPackageByTrackingNumber(string track){
            return await _context.Packages
            .Include(t => t.Trackings)
            .Include(u => u.User)
            .Include(a => a.Address)
            .Where(x=> x.TrackingNumber==track)
            .ToListAsync();
        }
        public async Task<bool> AddTracking(Tracking tracking){
            _context.Add(tracking);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}