﻿using taskflow.Models.Domain;

namespace taskflow.Repositories.Interfaces;

public interface IWorkspaceMemberRepository
{
    public Task<WorkspaceMember> CreateAsync(WorkspaceMember workspaceMember);

    public Task<WorkspaceMember> ShowAsync(Workspace workspace, Guid id);

    public Task<ICollection<Workspace>> FindAllAsync(Workspace workspace);
    
    public Task<WorkspaceMember> DeleteAsync(Workspace workspace, Guid id);

}