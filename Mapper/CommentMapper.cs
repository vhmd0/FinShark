using finshark.Dtos;
using finshark.Model;
using Riok.Mapperly.Abstractions;

namespace finshark.Mapper;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName, EnumMappingIgnoreCase = true)]
public partial class CommentMapper
{
    public partial Comment ToComment(CreateCommentDto commentDto);
    public partial CommentDto ToCommentDto(Comment comment);
 
}

