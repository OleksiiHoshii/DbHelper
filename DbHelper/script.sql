USE [Invoice]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2/14/2021 11:46:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 2/14/2021 11:46:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[DueDate] [datetime2](7) NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[CustomerId] [bigint] NULL,
	[InvoiceNo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceLines]    Script Date: 2/14/2021 11:46:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceLines](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[LineItem] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Unit] [nvarchar](max) NULL,
	[Amount] [float] NOT NULL,
	[Sum] [float] NOT NULL,
	[InvoiceId1] [bigint] NULL,
	[InvoiceId] [bigint] NULL,
 CONSTRAINT [PK_InvoiceLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoice]  WITH NOCHECK ADD  CONSTRAINT [FK_Invoices_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoices_Customers_CustomerId]
GO
ALTER TABLE [dbo].[InvoiceLines]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceLines_Invoices_InvoiceId] FOREIGN KEY([InvoiceId])
REFERENCES [dbo].[Invoice] ([Id])
GO
ALTER TABLE [dbo].[InvoiceLines] CHECK CONSTRAINT [FK_InvoiceLines_Invoices_InvoiceId]
GO
ALTER TABLE [dbo].[InvoiceLines]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceLines_Invoices_InvoiceId1] FOREIGN KEY([InvoiceId1])
REFERENCES [dbo].[Invoice] ([Id])
GO
ALTER TABLE [dbo].[InvoiceLines] CHECK CONSTRAINT [FK_InvoiceLines_Invoices_InvoiceId1]
GO
