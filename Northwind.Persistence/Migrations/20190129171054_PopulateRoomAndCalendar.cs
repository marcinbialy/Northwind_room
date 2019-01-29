using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.Persistence.Migrations
{
    public partial class PopulateRoomAndCalendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Rooms (RoomName) VALUES ('Room1')");
            migrationBuilder.Sql("INSERT INTO Rooms (RoomName) VALUES ('Room2')");
            migrationBuilder.Sql("INSERT INTO Rooms (RoomName) VALUES ('Room3')");

            migrationBuilder.Sql("INSERT INTO Calendars (CalendarDate, RoomId) VALUES ('2018-07-04', (SELECT RoomId FROM Rooms WHERE RoomName='Room1'))");
            migrationBuilder.Sql("INSERT INTO Calendars (CalendarDate, RoomId) VALUES ('2017-10-10', (SELECT RoomId FROM Rooms WHERE RoomName='Room1'))");
            migrationBuilder.Sql("INSERT INTO Calendars (CalendarDate, RoomId) VALUES ('1996-01-05', (SELECT RoomId FROM Rooms WHERE RoomName='Room2'))");
            migrationBuilder.Sql("INSERT INTO Calendars (CalendarDate, RoomId) VALUES ('1999-12-23', (SELECT RoomId FROM Rooms WHERE RoomName='Room3'))");
            migrationBuilder.Sql("INSERT INTO Calendars (CalendarDate, RoomId) VALUES ('2005-03-30', (SELECT RoomId FROM Rooms WHERE RoomName='Room2'))");
            migrationBuilder.Sql("INSERT INTO Calendars (CalendarDate, RoomId) VALUES ('2010-11-15', (SELECT RoomId FROM Rooms WHERE RoomName='Room3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Rooms");
            migrationBuilder.Sql("DELETE FROM Calendars");
        }
    }
}
