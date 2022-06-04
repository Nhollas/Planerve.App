module.exports = {
    content: [
    // Example content paths...
    "./Areas/*/Views/*/*.cshtml",
    "./Views/Shared/_*.cshtml",
    ],
    theme: {
        borderWidth: {
            '1': '1px'
        },
        extend: {
            maxWidth: {
                'mobile' : '',
            },
            fontFamily: {
                raleway: ["Raleway", "sans-serif"],
                poppins: ["Poppins", "sans-serif"],
            },
            colors: {
                'main-white': '#FEFFFF',
            },
        },
    },
    plugins: [],
};
