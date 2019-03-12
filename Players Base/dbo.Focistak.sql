CREATE TABLE [dbo].[Focistak] (
    [FocistaID] INT           IDENTITY (1, 1) NOT NULL,
    [Név]       NVARCHAR (50) NOT NULL,
    [SzulDat]   DATETIME2 (7) NULL,
    [CsapatFK]  INT           NULL,
    [PosztFK]   CHAR (1)      NULL,
    PRIMARY KEY CLUSTERED ([FocistaID] ASC),
    CONSTRAINT [FK_Focistak_Csapat] FOREIGN KEY ([CsapatFK]) REFERENCES [dbo].[Csapat] ([CsapatSK]),
    CONSTRAINT [FK_Focistak_Poszt] FOREIGN KEY ([PosztFK]) REFERENCES [dbo].[Poszt] ([PosztID])
);

