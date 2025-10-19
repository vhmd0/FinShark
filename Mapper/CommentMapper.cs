using finshark.Dtos;
using finshark.Model;
using Riok.Mapperly.Abstractions;

namespace finshark.Mapper;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName, EnumMappingIgnoreCase = true)]
public static partial class CommentMapper
{
    public static partial Comment ToComment(this CreateCommentDto commentDto);
    public static partial CommentDto ToCommentDto(this Comment comment);
}
