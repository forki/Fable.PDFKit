
import { default as PDFDocument } from 'pdfkit';
import { default as SVGtoPDF } from 'svg-to-pdfkit';

PDFDocument.prototype.addSVG = function (svg, x, y, options) {
    return SVGtoPDF(this, svg, x, y, options), this;
};

export function createDocument (settings) {
    return new PDFDocument(settings);
}
