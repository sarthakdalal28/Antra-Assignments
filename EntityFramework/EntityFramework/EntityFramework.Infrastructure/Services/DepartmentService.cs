using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repositories;
using Serilog;

namespace EntityFramework.Infrastructure.Services;

public class DepartmentService: IDepartmentService
{
    private DepartmentRepository _departmentRepository = new DepartmentRepository();
    public List<DepartmentResponseModel> GetAllDepartments()
    {
        var Departments = _departmentRepository.GetAll();
        var DepartmentResponseModels = new List<DepartmentResponseModel>();
        foreach (var Department in Departments)
        {
            DepartmentResponseModels.Add(new DepartmentResponseModel
            {
                DepartmentName = Department.DepartmentName,
                Location = Department.Location
            });
        }
        Log.Information("GetAll Department method has been called");
        return DepartmentResponseModels;
    }

    public DepartmentResponseModel GetById(int id)
    {
        var Department = _departmentRepository.GetById(id);
        if (Department != null)
        {
            var DepartmentResponseModel = new DepartmentResponseModel
            {
                DepartmentName = Department.DepartmentName,
                Location = Department.Location
            };
            
            return DepartmentResponseModel;
        }
        Log.Error($"Department with id {id} is not found");
        return null;
    }

    public int AddDepartment(DepartmentRequestModel model)
    {
        var DepartmentEntity = new Department
        {
            DepartmentName = model.DepartmentName,
            Location = model.Location,
        };

        if (_departmentRepository.Insert(DepartmentEntity) > 0)
        {
            Log.Information("Department has been added");
            return 1;
        }
        Log.Error("Adding Department failed!");
        return 0;
    }

    public int UpdateDepartment(int id, DepartmentRequestModel model)
    {
        var DepartmentEntity = new Department
        {
            Id = id,
            DepartmentName = model.DepartmentName,
            Location = model.Location,
        };
        if (_departmentRepository.Update(DepartmentEntity) > 0)
        {
            Log.Information("Department has been updated");
            return 1;
        }
        Log.Error("Updating Department failed!");
        return 0;
    }

    public int DeleteDepartmentById(int id)
    {
        var Department = _departmentRepository.GetById(id);
        if (Department != null && _departmentRepository.DeleteById(id) > 0)
        {
            Log.Information($"Department {id} has been deleted");
            return 1;
        }
        Log.Error($"Department with id {id} is not found");
        return 0;
    }
}