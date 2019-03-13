namespace VLS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.GpsDatas", name: "vehId", newName: "Imei");
            RenameIndex(table: "dbo.GpsDatas", name: "IX_vehId", newName: "IX_Imei");
            AddColumn("dbo.Vehicles", "SimcardNo", c => c.String(nullable: false));
            AddColumn("dbo.Vehicles", "Imei", c => c.String(nullable: false));
            AddColumn("dbo.Vehicles", "DriverName", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "DriverAddress", c => c.String(nullable: false));
            AddColumn("dbo.Vehicles", "DriverPhoneNo", c => c.String(nullable: false));
            AddColumn("dbo.Vehicles", "PolicyStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vehicles", "PolicyEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vehicles", "DriverImage", c => c.Binary());
            AddColumn("dbo.GpsDatas", "Header", c => c.Byte(nullable: false));
            AddColumn("dbo.GpsDatas", "Lenght", c => c.String());
            AddColumn("dbo.GpsDatas", "VehicleStatus", c => c.String());
            AddColumn("dbo.GpsDatas", "DateTime", c => c.String());
            AddColumn("dbo.GpsDatas", "BatteryVoltage", c => c.String());
            AddColumn("dbo.GpsDatas", "SuplayVoltage", c => c.String());
            AddColumn("dbo.GpsDatas", "Adc1", c => c.String());
            AddColumn("dbo.GpsDatas", "Adc2", c => c.String());
            AddColumn("dbo.GpsDatas", "Adc3", c => c.String());
            AddColumn("dbo.GpsDatas", "Adc4", c => c.String());
            AddColumn("dbo.GpsDatas", "TemperatureA", c => c.String());
            AddColumn("dbo.GpsDatas", "TemperatureB", c => c.String());
            AddColumn("dbo.GpsDatas", "LACCI", c => c.String());
            AddColumn("dbo.GpsDatas", "CellId", c => c.String());
            AddColumn("dbo.GpsDatas", "GPSSatellites", c => c.String());
            AddColumn("dbo.GpsDatas", "GSMsignal", c => c.String());
            AddColumn("dbo.GpsDatas", "HDOP", c => c.String());
            AddColumn("dbo.GpsDatas", "NS", c => c.String());
            AddColumn("dbo.GpsDatas", "EW", c => c.String());
            AddColumn("dbo.GpsDatas", "SerialNumber", c => c.String());
            AddColumn("dbo.GpsDatas", "Checksum", c => c.String());
            AlterColumn("dbo.Customers", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "VehicleName", c => c.String(nullable: false));
            AlterColumn("dbo.Vehicles", "VehicleNo", c => c.String(nullable: false));
            DropColumn("dbo.GpsDatas", "MyProperty");
            DropColumn("dbo.GpsDatas", "Locate");
            DropColumn("dbo.GpsDatas", "Atime");
            DropColumn("dbo.GpsDatas", "Temperature");
            DropColumn("dbo.Users", "Company");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Company", c => c.String());
            AddColumn("dbo.GpsDatas", "Temperature", c => c.Int(nullable: false));
            AddColumn("dbo.GpsDatas", "Atime", c => c.DateTime(nullable: false));
            AddColumn("dbo.GpsDatas", "Locate", c => c.Int(nullable: false));
            AddColumn("dbo.GpsDatas", "MyProperty", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "VehicleNo", c => c.String());
            AlterColumn("dbo.Vehicles", "VehicleName", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "FullName", c => c.String());
            DropColumn("dbo.GpsDatas", "Checksum");
            DropColumn("dbo.GpsDatas", "SerialNumber");
            DropColumn("dbo.GpsDatas", "EW");
            DropColumn("dbo.GpsDatas", "NS");
            DropColumn("dbo.GpsDatas", "HDOP");
            DropColumn("dbo.GpsDatas", "GSMsignal");
            DropColumn("dbo.GpsDatas", "GPSSatellites");
            DropColumn("dbo.GpsDatas", "CellId");
            DropColumn("dbo.GpsDatas", "LACCI");
            DropColumn("dbo.GpsDatas", "TemperatureB");
            DropColumn("dbo.GpsDatas", "TemperatureA");
            DropColumn("dbo.GpsDatas", "Adc4");
            DropColumn("dbo.GpsDatas", "Adc3");
            DropColumn("dbo.GpsDatas", "Adc2");
            DropColumn("dbo.GpsDatas", "Adc1");
            DropColumn("dbo.GpsDatas", "SuplayVoltage");
            DropColumn("dbo.GpsDatas", "BatteryVoltage");
            DropColumn("dbo.GpsDatas", "DateTime");
            DropColumn("dbo.GpsDatas", "VehicleStatus");
            DropColumn("dbo.GpsDatas", "Lenght");
            DropColumn("dbo.GpsDatas", "Header");
            DropColumn("dbo.Vehicles", "DriverImage");
            DropColumn("dbo.Vehicles", "PolicyEndDate");
            DropColumn("dbo.Vehicles", "PolicyStartDate");
            DropColumn("dbo.Vehicles", "DriverPhoneNo");
            DropColumn("dbo.Vehicles", "DriverAddress");
            DropColumn("dbo.Vehicles", "DriverName");
            DropColumn("dbo.Vehicles", "Imei");
            DropColumn("dbo.Vehicles", "SimcardNo");
            RenameIndex(table: "dbo.GpsDatas", name: "IX_Imei", newName: "IX_vehId");
            RenameColumn(table: "dbo.GpsDatas", name: "Imei", newName: "vehId");
        }
    }
}
