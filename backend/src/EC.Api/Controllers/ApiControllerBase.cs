using Template.Infrastructure.RoutePrefix;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Template.Api.Controllers;

[ApiController]
[RoutePrefix("api/")]
public abstract class ApiControllerBase : ControllerBase
{
#pragma warning disable CS8618 // ����, �� ����������� �������� NULL, ������ ��������� ��������, �������� �� NULL, ��� ������ �� ������������. ��������, ����� �������� ���� ��� ����������� �������� NULL.
    private ISender _sender;
#pragma warning restore CS8618 // ����, �� ����������� �������� NULL, ������ ��������� ��������, �������� �� NULL, ��� ������ �� ������������. ��������, ����� �������� ���� ��� ����������� �������� NULL.

    protected ISender Sender => _sender ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}