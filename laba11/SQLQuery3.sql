SELECT u.Email, c.ClaimType, c.ClaimValue
FROM dbo.AspNetUserClaims AS c
    INNER JOIN dbo.AspNetUsers AS u
    ON c.UserId = u.Id