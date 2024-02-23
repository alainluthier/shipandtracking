using System;
using System.Collections.Generic;
using System.Linq;
using ShipAndTrack.Models;
using ShipAndTrack.Data;
using Microsoft.EntityFrameworkCore;

namespace ShipAndTrack.Services
{
    public class PackageService
    {
        
        private readonly ShipAndTrackContext _context;
        //Creating the service with a database connection
        public PackageService(ShipAndTrackContext context)
        {
            _context = context;
        }
        //This async function will return a task with a list of packages by a Tracking number
        public async Task<List<Package>> GetPackageByTrackingNumber(string track)
        {
            return await _context.Packages
            .Include(t => t.Trackings)
            .Include(u => u.User)
            .Include(a => a.Address)
            .Where(x => x.TrackingNumber == track)
            .ToListAsync();
        }
        //This function will add a new Tracking status
        public async Task<bool> AddTracking(Tracking tracking)
        {
            _context.Add(tracking);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<string> GetLatestTrackingStatusByTrackingNumber(string track)
        {
            var latestTracking = await _context.Packages
                .Where(p => p.TrackingNumber == track)
                .SelectMany(p => p.Trackings)
                .OrderByDescending(t => t.CreatedAt)
                .FirstOrDefaultAsync();

            return latestTracking?.Status;
        }


        public async Task<bool> AddPackage(Package package)
        {
            _context.Add(package);
            var result = await _context.SaveChangesAsync();
            return (result > 0);
        }
    }
}